# [Game Title] — Game Design Document

> **"A delayed game is eventually good, but a rushed game is forever bad."**
> — Shigeru Miyamoto

---

## Document Info

**Project:** [Game Title]
**Genre:** [Genre]
**Platform:** [Platforms]
**Target Audience:** [Audience]
**Status:** [Pre-production / Production / Polish]
**Last Updated:** [Date]

---

## Table of Contents

1. [Vision Statement](#1-vision-statement)
2. [Core Gameplay Loop](#2-core-gameplay-loop)
3. [Mechanics](#3-mechanics)
4. [Progression Systems](#4-progression-systems)
5. [Level Design](#5-level-design)
6. [Narrative Design](#6-narrative-design)
7. [Lore Delivery System](#7-lore-delivery-system)
8. [Characters](#8-characters)
9. [User Interface](#9-user-interface)
10. [Art Direction](#10-art-direction)
11. [Audio Design](#11-audio-design)
12. [Accessibility](#12-accessibility)
13. [Monetization](#13-monetization)
14. [Competitive Analysis](#14-competitive-analysis)
15. [Milestones](#15-milestones)
16. [Revision History](#16-revision-history)

---

## 1. Vision Statement

### Elevator Pitch
*One to two sentences that capture the essence of the game.*

[Your pitch here]

### Pillars
*Three to five core principles that guide every design decision.*

1. **[Pillar 1]** — [Brief explanation]
2. **[Pillar 2]** — [Brief explanation]
3. **[Pillar 3]** — [Brief explanation]

### Target Experience
*How should the player FEEL while playing?*

[Describe the emotional journey]

### Unique Selling Points
*What makes this game different from competitors?*

- [USP 1]
- [USP 2]
- [USP 3]

---

## 2. Core Gameplay Loop

### Primary Loop (Moment-to-Moment)
*What does the player do every few seconds?*

```
[Action] → [Feedback] → [Reward] → [Repeat]
```

### Session Loop (Per Play Session)
*What does a typical 30-60 minute session look like?*

```
[Start] → [Progression] → [Challenge] → [Resolution] → [Save/Exit]
```

### Meta Loop (Long-term Progression)
*What keeps players coming back over days/weeks?*

```
[Goal] → [Unlock] → [New Content] → [New Goal]
```

---

## 3. Mechanics

### Core Mechanics

| Mechanic | Description | Input | Feedback |
|----------|-------------|-------|----------|
| [Mechanic 1] | [What it does] | [Player input] | [Visual/audio feedback] |
| [Mechanic 2] | [What it does] | [Player input] | [Visual/audio feedback] |

### Secondary Mechanics

| Mechanic | Description | Unlocked |
|----------|-------------|----------|
| [Mechanic] | [What it does] | [When/how unlocked] |

### Controls

| Action | Keyboard | Controller |
|--------|----------|------------|
| [Action] | [Key] | [Button] |

---

## 4. Progression Systems

### Player Progression

| System | Description | Impact |
|--------|-------------|--------|
| [XP/Levels] | [How it works] | [What it unlocks] |
| [Skills] | [How it works] | [What it unlocks] |
| [Equipment] | [How it works] | [What it unlocks] |

### Difficulty Curve

```
Early Game    → [Description of challenge level]
Mid Game      → [Description of challenge level]
Late Game     → [Description of challenge level]
Post-Game     → [Description of challenge level]
```

### Unlock Flow

*What order does the player unlock content?*

```
[Starting content] → [First unlock] → [Second unlock] → ...
```

---

## 5. Level Design

### Level Structure

| Level/Area | Theme | Mechanics Introduced | Boss/Challenge |
|------------|-------|---------------------|----------------|
| [Level 1] | [Theme] | [New mechanics] | [Challenge] |
| [Level 2] | [Theme] | [New mechanics] | [Challenge] |

### Level Design Principles

1. **[Principle 1]** — [Explanation]
2. **[Principle 2]** — [Explanation]
3. **[Principle 3]** — [Explanation]

---

## 6. Narrative Design

### Story Synopsis

*Brief overview of the main story (no spoilers for public docs).*

[Synopsis here]

### Narrative Structure

| Act | Summary | Player Goal |
|-----|---------|-------------|
| Act 1 | [Setup] | [What player wants] |
| Act 2 | [Confrontation] | [What player wants] |
| Act 3 | [Resolution] | [What player wants] |

### Themes

- **Primary Theme:** [Theme]
- **Secondary Themes:** [Theme], [Theme]

### Player Agency

*How do player choices affect the narrative?*

| Choice Type | Impact | Example |
|-------------|--------|---------|
| [Dialogue] | [Impact level] | [Example] |
| [Actions] | [Impact level] | [Example] |
| [Endings] | [Impact level] | [Example] |

---

## 7. Lore Delivery System

### Philosophy

*Respect player time while rewarding curiosity.*

- Lore-hungry players get deep worldbuilding
- Time-pressed players get key information
- No one misses critical story beats
- Reading is never a chore

### TLDR Dropdown System

**Concept:** Every lore note has an expandable TLDR summary hidden at the bottom.

**Interaction Flow:**

```
┌─────────────────────────────────────────────────┐
│ [NOTE TITLE]                                    │
│━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━│
│                                                 │
│ [Full text of the note displayed here...]       │
│                                                 │
│ [Multiple paragraphs if needed...]              │
│                                                 │
│ ▼ TLDR                                          │
└─────────────────────────────────────────────────┘

        Player clicks ▼ to expand
              │
              ▼

┌─────────────────────────────────────────────────┐
│ [NOTE TITLE]                                    │
│━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━│
│                                                 │
│ [Full text...]                                  │
│                                                 │
│ ▲ TLDR                                          │
│ ┌─────────────────────────────────────────────┐ │
│ │ [2-3 sentence summary of key information]   │ │
│ └─────────────────────────────────────────────┘ │
└─────────────────────────────────────────────────┘
```

**Why Hidden by Default:**
- No spoilers — player reads full note first if they want
- Preserves discovery — TLDR is a reference tool, not a shortcut
- Player agency — they choose their experience

### Note Types & Presentation

| Note Type | Visual Style | TLDR Voice | Wear/Texture |
|-----------|--------------|------------|--------------|
| Corporate Memo | Clean sans-serif, official letterhead | Neutral, bureaucratic | Pristine, stamped "CLASSIFIED" |
| Personal Notes | Handwritten, weathered paper | Emotional, personal | Tear stains, fold creases, sand grains |
| Intel Reports | Monospace, terminal/encrypted look | Tactical, coded slang | Redacted sections, burn marks |
| News Articles | Newspaper column layout | Headline journalism | Coffee stains, torn edges |
| Journals/Diaries | Cursive or messy handwriting | Stream of consciousness | Water damage, pressed flowers |
| Propaganda | Bold graphics, bright colors | Corporate speak, upbeat | Faded from sun, graffiti over it |

### TLDR Voice Examples

**Corporate Memo:**
```
▼ TLDR
┌────────────────────────────────────────┐
│ Redwood Division reports 3 missing     │
│ shipments. Internal investigation      │
│ ongoing. No suspects identified.       │
└────────────────────────────────────────┘
```

**Personal Note (Emotional):**
```
▼ TLDR
┌────────────────────────────────────────┐
│ I found her necklace in the wreckage.  │
│ They took everything else.             │
│ I'm going to find out who.             │
└────────────────────────────────────────┘
```

**Riptide Intel:**
```
▼ TLDR
┌────────────────────────────────────────┐
│ 3 shipments = ours. Corpos don't know. │
│ Keep heads down. High tide tomorrow.   │
└────────────────────────────────────────┘
```

### Visual Storytelling Through Wear

Notes tell stories before the player reads a word:

| Wear Type | What It Tells the Player |
|-----------|--------------------------|
| Tear stains | This one is emotional, prepare yourself |
| Burn marks | Someone tried to destroy this |
| Fold creases | Carried for a long time, important to owner |
| Blood splatter | Violence involved |
| Coffee rings | Someone's daily reading, mundane |
| Sand/dirt | Found outdoors, field conditions |
| Redacted sections | Secrets hidden, incomplete info |
| Graffiti/defacement | Propaganda rejected by locals |

### Collectible Tracking

| Feature | Description |
|---------|-------------|
| Note Log | All found notes accessible from menu |
| Completion % | [X/Total] notes found per area |
| New indicator | Unread notes marked until opened |
| Filter/Sort | By type, location, chronological |
| Search | Find notes by keyword |

---

## 8. Characters

### Main Characters

| Character | Role | Brief Description |
|-----------|------|-------------------|
| [Name] | [Role] | [1-2 sentences] |

### Supporting Characters

| Character | Role | Brief Description |
|-----------|------|-------------------|
| [Name] | [Role] | [1-2 sentences] |

### Character Design Principles

1. **[Principle]** — [Explanation]
2. **[Principle]** — [Explanation]

*Note: Full character details belong in the World Bible, not the GDD.*

---

## 9. User Interface

### UI Philosophy

*What principles guide UI design?*

- [Principle 1]
- [Principle 2]
- [Principle 3]

### Key Screens

| Screen | Purpose | Key Elements |
|--------|---------|--------------|
| Main Menu | Entry point | [Elements] |
| HUD | In-game info | [Elements] |
| Pause Menu | Options, save | [Elements] |
| Inventory | Item management | [Elements] |

### HUD Layout

```
[Sketch or description of HUD layout]
```

---

## 10. Art Direction

### Visual Style

*Describe the overall aesthetic.*

[Description]

### Color Palette

| Usage | Colors | Meaning |
|-------|--------|---------|
| [Usage] | [Colors] | [What it communicates] |

### Reference Images

*List reference games, films, art that capture the target aesthetic.*

- [Reference 1]
- [Reference 2]
- [Reference 3]

---

## 11. Audio Design

### Music Direction

*Describe the musical style, instrumentation, mood.*

[Description]

### Sound Effects Philosophy

*What should SFX communicate? Realistic? Stylized?*

[Description]

### Key Audio Moments

| Moment | Audio Goal |
|--------|------------|
| [Moment] | [What player should feel] |

---

## 12. Accessibility

### Accessibility Features

| Feature | Description | Status |
|---------|-------------|--------|
| Subtitles | Dialogue text on screen | [Planned/Done] |
| Colorblind modes | Alternative color schemes | [Planned/Done] |
| Remappable controls | Custom key bindings | [Planned/Done] |
| Text scaling | Adjustable UI text size | [Planned/Done] |
| TLDR system | Lore summaries for time-pressed players | [Planned/Done] |

### Difficulty Options

| Option | Description |
|--------|-------------|
| [Option] | [What it changes] |

---

## 13. Monetization

### Business Model

*Premium? Free-to-play? Early Access?*

[Model description]

### Pricing

| SKU | Price | Contents |
|-----|-------|----------|
| Base Game | [$X] | [Contents] |
| Deluxe | [$X] | [Contents] |
| DLC | [$X] | [Contents] |

---

## 14. Competitive Analysis

### Similar Games

| Game | Similarities | Differences | What We Learn |
|------|--------------|-------------|---------------|
| [Game] | [Similar elements] | [How we differ] | [Takeaway] |

### Market Position

*Where does this game fit in the market?*

[Analysis]

---

## 15. Milestones

### Development Timeline

| Milestone | Target Date | Deliverables |
|-----------|-------------|--------------|
| Prototype | [Date] | [What's playable] |
| Vertical Slice | [Date] | [What's playable] |
| Alpha | [Date] | [What's playable] |
| Beta | [Date] | [What's playable] |
| Gold | [Date] | [What's playable] |
| Launch | [Date] | [Release] |

---

## 16. Revision History

| Date | Version | Changes |
|------|---------|---------|
| [Date] | [X.X] | [What changed] |

---

*This is a living document. Update as design evolves.*
