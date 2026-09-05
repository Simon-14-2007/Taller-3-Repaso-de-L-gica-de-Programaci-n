# Workshop 2 - Object-Oriented Programming

Two independent exercises solved with an object-oriented approach in C#, sharing a common `Shared` project as required by the assignment.

## Exercises

### 1. Madison Bridges (`MadisonBridges/`)

Validates whether a text sequence made of `*` (base), `=` (platform) and `+` (reinforcement) represents a valid bridge, according to these rules:
- Bases can only appear at the extremes of the bridge.
- Platform groups must be exactly 2 tiles long, or exactly 3 tiles long only if centered.
- Every platform group must be bounded on both sides by a base or a reinforcement.
- The bridge must be symmetric.
- Consecutive reinforcements are allowed with no limit.

**Key classes:** `Bridge`, `BridgeValidator`.

**Run it:**
```bash
dotnet run --project MadisonBridges
```
Enter a bridge sequence when prompted (press Enter with no input to exit).

### 2. Horse Harvest (`HorseHarvest/`)

Simulates a chess knight moving across an 8x8 board to collect fruits planted on specific tiles, following a custom move notation (UL, UR, LU, LD, RU, RD, DL, DR — each combining a 2-tile direction and a 1-tile direction).

**Key classes:** `Position`, `KnightMove`, `Board`, `Knight`, `HarvestSimulator`.

**Run it:**
```bash
dotnet run --project HorseHarvest
```
Example input: