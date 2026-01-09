# NeonVoid World Bible - GitHub Repository Structure

This document outlines the recommended GitHub repository structure for your NeonVoid project.

## Why GitHub for Your World Bible?

**Version Control Benefits:**
- See exactly what changed and when
- Revert to previous versions if you don't like a change
- Track your creative evolution over time
- Branch to experiment without breaking main canon

**Organization Benefits:**
- Everything in one searchable place
- Markdown files = clean, readable, portable
- Easy to reorganize as the project grows
- Can collaborate with others (artists, co-writers) later

**Backup Benefits:**
- Cloud-hosted automatically
- Can't lose your work
- Access from anywhere

## Recommended Repository Structure

```
neonvoid-world-bible/
│
├── README.md                          # Project overview, quick navigation
│
├── 01-overview/
│   ├── premise.md
│   ├── genre-and-tone.md
│   ├── core-themes.md
│   └── player-experience.md
│
├── 02-timeline/
│   ├── historical-background.md
│   ├── 21-years-before.md
│   ├── inciting-incident.md
│   ├── intervening-years.md
│   └── present-day.md
│
├── 03-factions/
│   ├── legacy-dynamics.md
│   ├── hydrus.md
│   ├── uplink.md
│   ├── corporate-council.md
│   ├── tbd-red-line.md
│   ├── waveborn.md
│   └── templars.md
│
├── 04-governments/
│   ├── terran-confederacy.md
│   └── [others-tbd].md
│
├── 05-society/
│   ├── class-dynamics.md
│   ├── corporate-worker-life.md
│   ├── employee-class.md
│   └── underemployed-citizens.md
│
├── 06-technology/
│   ├── overview.md
│   ├── biotech-enhancement.md
│   ├── space-habitats.md
│   ├── propulsion-systems.md
│   ├── spacecraft-design.md
│   ├── physics-energy.md
│   └── communications.md
│
├── 07-locations/
│   ├── the-drift.md
│   ├── corp-facility-original.md
│   ├── wellspring-colony.md
│   └── [others-tbd].md
│
├── 08-characters/
│   ├── cora.md
│   ├── edwin.md
│   ├── thatcher.md
│   ├── voss.md
│   ├── asher-koa-flynn.md
│   └── [others-tbd].md
│
├── 09-items-artifacts/
│   ├── knight-of-thatched-hall.md
│   ├── coras-ocular-implants.md
│   ├── genetic-data.md
│   └── sir-cedrics-sword.md
│
├── 10-story-structure/
│   ├── core-conflict.md
│   ├── act-one.md
│   ├── act-two.md
│   ├── act-three.md
│   └── possible-endings.md
│
├── 11-key-scenes/
│   ├── the-video.md
│   ├── finish-the-story.md
│   ├── thatcher-understands.md
│   ├── koa-tells-his-story.md
│   └── koa-fixes-the-board.md
│
├── 12-dialogue-voice/
│   ├── locked-phrases.md
│   ├── character-voices.md
│   └── [specific-dialogues].md
│
├── 13-themes/
│   ├── question-vs-command.md
│   ├── betrayal-hasty-check.md
│   ├── sanctuary-and-loss.md
│   └── gift-that-binds.md
│
├── 14-appendices/
│   ├── knight-of-thatched-hall-full-text.md
│   ├── visual-references.md
│   └── session-notes.md
│
├── 15-open-questions/
│   └── tracking.md                  # Living document of unanswered questions
│
├── assets/                           # Images, maps, concept art
│   ├── character-portraits/
│   ├── location-concepts/
│   └── faction-logos/
│
├── tools/                            # Useful scripts and templates
│   ├── character-template.md
│   ├── faction-template.md
│   └── location-template.md
│
└── archive/                          # Old versions, cut content
    └── deprecated/
```

## File Naming Conventions

- Use lowercase with hyphens: `space-habitats.md` not `Space Habitats.md`
- Number folders for order: `01-overview`, `02-timeline`
- Keep names descriptive but concise
- Use `.md` extension for all text files (Markdown)

## Branching Strategy

**main branch** = canonical world bible
**development branch** = working on major updates
**feature branches** = experimenting with specific ideas

Example workflow:
```
main (canon)
  ├── development (staging)
  │     ├── feature/new-faction-banking-corp
  │     └── feature/expand-koa-backstory
```

## Markdown Quick Reference

```markdown
# Heading 1
## Heading 2
### Heading 3

**bold text**
*italic text*

- Bullet point
  - Nested bullet
  
1. Numbered list
2. Item two

> Blockquote

`code or tech term`

[Link text](url)

---
Horizontal rule
```

## Getting Started Steps

1. Create GitHub account (if you don't have one)
2. Create new repository called `neonvoid-world-bible`
3. Choose: Private (recommended) or Public
4. Clone to your computer
5. Create folder structure above
6. Start moving content into markdown files
7. Commit and push regularly

## Git Commands You'll Use Most

```bash
# See what changed
git status

# Add files to be committed
git add .

# Save changes with message
git commit -m "Add space communications tech section"

# Upload to GitHub
git push

# Download latest from GitHub
git pull
```

## Tips

- Commit often with clear messages
- Use branches for big experiments
- Link between documents using relative paths
- Keep a changelog in the README
- Use GitHub Issues to track ideas and questions

## Next Steps

Once this structure is set up, you can:
- Search across all files instantly
- Track which sections are complete vs. TBD
- See your progress over time
- Share specific sections with others
- Export to other formats if needed
