# Signal Surfer — Technical Architecture Document

> **"Remember that the only valid measurement of code quality: WTFs/Minute"**
> — Robert C. Martin (Uncle Bob), *Clean Code*

---

## 1. Project Overview

**Project:** Signal Surfer
**Type:** Hacking minigame for The Dark Void
**Status:** In Development
**Last Updated:** January 2026

One-paragraph description:
Signal Surfer is a wave-tracing puzzle minigame where players trace signal waveforms on a grid. It features two visual modes: Hacker View (top-down grid) and Surfer View (side-scrolling wave rider). The minigame serves as a hacking mechanic within The Dark Void and doubles as a recruitment/training tool in-universe for the Riptide Collective.

---

## 2. Tech Stack

| Tool | Version | Purpose |
|------|---------|---------|
| Unity | [Your Version] | Game engine |
| C# | .NET Standard 2.1 | Scripting |
| Blender | [Your Version] | 3D modeling, sprites |
| Git | Latest | Version control |
| GitHub | — | Remote repository |
| VS Code | Latest | Code editor |

---

## 3. Folder Structure

```
Signal-Surfer/
├── Assets/
│   ├── DJR Scripts/          # All custom C# scripts
│   │   ├── Core/             # Future: Production-ready scripts
│   │   └── DJRCore/          # Practice/training scripts
│   ├── Prefabs/              # Reusable game objects
│   ├── Scenes/               # Unity scenes
│   ├── ScriptableObjects/    # Data assets (levels, grid shapes)
│   │   └── Levels/           # Level data assets
│   ├── Sprites/              # 2D art assets
│   ├── Materials/            # Materials and shaders
│   └── Audio/                # Sound effects, music
├── Packages/                 # Unity packages
├── ProjectSettings/          # Unity project settings
└── README.md
```

---

## 4. Core Systems

### Implemented ✅

| System | Description | Primary Script(s) |
|--------|-------------|-------------------|
| Grid System | Spawns and manages the cell grid | `GridRenderer.cs`, `GridShapeDefinition.cs` |
| Cell System | Individual cell data and behavior | `CellCode.cs`, `CellBehavior.cs` |
| Wave Segments | Defines visual wave pieces | `WaveSegment.cs` |
| Level Data | Defines level layout and correct path | `LevelData.cs`, `LevelDataAsset.cs` |
| Game Manager | Tracks game state, validates player input | `GameManager.cs` |

### Planned 🔲

| System | Description | Target Script(s) |
|--------|-------------|------------------|
| Path Validation | Visual reset after wrong move | `CellBehavior.cs`, `GridRenderer.cs` |
| Surfer View | Side-scrolling wave renderer | `SurfRenderer.cs` (planned) |
| Input Manager | WASD + Jump for Surfer View | `SurferInput.cs` (planned) |
| Audio System | SFX and music | TBD |
| UI System | Menus, HUD, level select | TBD |
| Save System | Progress persistence | TBD |

---

## 5. Script Index

### Data Layer (No Unity Dependencies)

| Script | Purpose |
|--------|---------|
| `CellCode.cs` | Cell data: signal type, state, position, decay timer |
| `WaveSegment.cs` | Enum defining wave segment shapes (curves, diagonals, etc.) |
| `LevelData.cs` | Level definition: grid size, correct path, segments |

### Unity Layer (MonoBehaviours)

| Script | Purpose |
|--------|---------|
| `GridRenderer.cs` | Spawns cell prefabs based on level data |
| `GridShapeDefinition.cs` | ScriptableObject defining grid dimensions and cell mask |
| `CellBehavior.cs` | Cell click handling, visual feedback, selection ring |
| `LevelDataAsset.cs` | ScriptableObject wrapper for LevelData |
| `GameManager.cs` | Singleton managing game state, path validation, win/lose |

### Planned Scripts

| Script | Purpose |
|--------|---------|
| `SurfRenderer.cs` | Renders wave as side-scrolling terrain |
| `SurferController.cs` | Player movement in Surfer View |
| `AudioManager.cs` | Sound effect and music playback |
| `UIManager.cs` | Menu navigation, HUD updates |

---

## 6. Data Flow

```
┌─────────────────────────────────────────────────────────────┐
│                      GAME START                              │
└─────────────────────────────────────────────────────────────┘
                            │
                            ▼
┌─────────────────────────────────────────────────────────────┐
│  LevelDataAsset (ScriptableObject)                          │
│  - Rows, Columns                                            │
│  - Correct Path (List<Vector2Int>)                          │
│  - Path Segments (List<WaveSegment>)                        │
│  - Wave Type (SignalType)                                   │
└─────────────────────────────────────────────────────────────┘
                            │
            ┌───────────────┴───────────────┐
            ▼                               ▼
┌─────────────────────┐         ┌─────────────────────┐
│   GridRenderer      │         │   GameManager       │
│   - Reads level     │         │   - Reads level     │
│   - Spawns cells    │         │   - Tracks path     │
│   - Assigns segments│         │   - Validates input │
└─────────────────────┘         └─────────────────────┘
            │                               │
            ▼                               │
┌─────────────────────┐                     │
│   CellBehavior      │◄────────────────────┘
│   (per cell)        │
│   - Handles clicks  │
│   - Calls GameManager.TrySelectCell()
│   - Updates visuals │
└─────────────────────┘
            │
            ▼
┌─────────────────────┐
│   CellCode          │
│   (data per cell)   │
│   - Signal type     │
│   - State           │
│   - Decay timer     │
└─────────────────────┘
```

---

## 7. Scene Structure

| Scene | Purpose | Status |
|-------|---------|--------|
| `TestScene` | Development testing | ✅ Active |
| `MainMenu` | Title screen, options | 🔲 Planned |
| `LevelSelect` | Choose level/round | 🔲 Planned |
| `HackerView` | Grid-based gameplay | 🔲 Planned (currently in TestScene) |
| `SurferView` | Side-scroll gameplay | 🔲 Planned |

---

## 8. Asset Pipeline

### Blender → Unity Workflow

```
1. Create/edit model in Blender
2. Export as .FBX (or .blend directly)
3. Place in Assets/Models/ or Assets/Sprites/
4. Unity auto-imports
5. Create prefab if needed
6. Assign materials/textures
```

### Sprite Workflow (Wave Segments)

```
1. Design wave segment in Blender/2D software
2. Export as .PNG (transparent background)
3. Place in Assets/Sprites/WaveSegments/
4. Import settings: Sprite (2D), Filter: Point (pixel art) or Bilinear
5. Reference in CellBehavior for display
```

---

## 9. Version Control

### Repository

- **Remote:** GitHub
- **URL:** [Your GitHub URL]
- **Branch Strategy:** Simple (main + feature branches)

### Branch Naming

| Branch Type | Format | Example |
|-------------|--------|---------|
| Main | `main` | `main` |
| Feature | `feature/[name]` | `feature/surfer-view` |
| Bugfix | `fix/[name]` | `fix/cell-reset` |
| Experiment | `exp/[name]` | `exp/shader-test` |

### Commit Message Format

```
[Type] Short description

Types:
- [Add] New feature
- [Fix] Bug fix
- [Update] Changes to existing feature
- [Refactor] Code cleanup, no behavior change
- [Docs] Documentation only
- [WIP] Work in progress (don't merge)

Examples:
- [Add] Path validation in GameManager
- [Fix] Cell visuals not resetting on wrong click
- [Refactor] Extract WaveSegment to own file
```

---

## 10. Build & Deployment

### Development Build

```
File → Build Settings → PC, Mac & Linux Standalone
Development Build: ✅
Script Debugging: ✅
```

### Release Build (Future)

| Platform | Target | Status |
|----------|--------|--------|
| Windows | Steam | 🔲 Planned |
| Mac | Steam | 🔲 Planned |
| WebGL | itch.io demo | 🔲 Planned |

---

## 11. Testing

> *"Legacy code is code without tests."* — Michael Feathers

### Unit Tests (Data Layer)

| Test Suite | Tests | Status |
|------------|-------|--------|
| `CellCodeTests` | Cell creation, selection, state changes | 🔲 Planned |
| `LevelDataTests` | Path validation, segment lookup | 🔲 Planned |
| `WaveSegmentTests` | N/A (enum, nothing to test) | — |

### Integration Tests (Unity)

| Test | Description | Status |
|------|-------------|--------|
| Grid spawns correctly | Cells match level data | 🔲 Planned |
| Path tracing works | Correct clicks → win | 🔲 Planned |
| Wrong click resets | Visuals reset on mistake | 🔲 Planned |

### Manual Testing Checklist

- [ ] Grid spawns with correct dimensions
- [ ] Wave segments display on correct cells
- [ ] Clicking correct path → "LEVEL COMPLETE"
- [ ] Clicking wrong cell → visual feedback, attempt lost
- [ ] All attempts lost → "LEVEL FAILED"
- [ ] Cells reset after wrong click

---

## 12. Known Issues / Tech Debt

| Issue | Priority | Notes |
|-------|----------|-------|
| Cells don't reset visuals on wrong click | High | Need ResetVisuals() method |
| Selection ring uses hardcoded 5 positions | Low | Update to use totalNodes |
| Light chase effect incomplete | Low | Parked until March polish |
| Text labels need sprite replacement | Medium | Placeholder for now |

---

## 13. Revision History

| Date | Version | Changes |
|------|---------|---------|
| Jan 2026 | 0.1 | Initial TAD created |
| | | Grid system, cell system, game manager implemented |
| | | First test level (Sine Round 1 Up) working |

---

*This is a living document. Update as systems are added or changed.*
