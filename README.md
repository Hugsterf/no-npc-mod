# No NPC Mod

**An optimization mod that removes moving NPCs to improve game performance in Gamble With Your Friends.**

---

## What this mod does

This mod **disables the spawning of moving NPCs** (wandering characters) in the casino.

It does **NOT** remove important NPCs like vendors, quest givers, or story-related characters.

---

## Performance Impact

| Before | After |
|--------|-------|
| 20-40 active NPCs constantly pathfinding | 0 moving NPCs |
| High CPU load from AI calculations | Reduced CPU load |
| Possible FPS drops | Smoother framerate |

---

## Important Notes

- **Important NPCs are preserved** – Vendors and other key characters remain
- **Game progression is unaffected** – Quests and mechanics work correctly
- **Multiplayer compatible** – Host only

---

## Installation

1. Install **BepInEx 5.4.23+**
2. Place `NoNPCMod.dll` into `BepInEx/plugins/NoNPCMod/`

---

## Compatibility

- Single-player
- Multiplayer (host only)
- No conflicts with other mods

---

## Changelog

### 1.0.0
- Initial release
- Disables roaming NPC spawning
- Replaces spawn coroutines with empty coroutines (no null reference errors)
