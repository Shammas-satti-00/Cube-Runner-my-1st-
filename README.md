

https://github.com/user-attachments/assets/f4063017-7ea5-468d-b648-0ef6c51d0632

# Cube Runner

A simple 3D endless-runner-style Unity game. Move the player left and right, avoid obstacles, and reach the end of the level.

## Requirements

- Unity `6000.6.0f1`
- Windows or another platform supported by Unity

## How to Play

- Press `A` to move left.
- Press `D` to move right.
- Avoid obstacles and do not fall from the level.
- Reach the `END` trigger to complete the level.
- The score starts at zero when a run begins and increases as the player moves forward.

## Scenes

The scenes are included in the Unity build settings in this order:

1. `Assets/Menu.unity`
2. `Assets/level1.unity`
3. `Assets/CreditsScene.unity`

Start the game from `Menu.unity` or press Play with the Menu scene open.

## Project Structure

- `Assets/Scripits/` - Gameplay scripts such as movement, scoring, collisions, menus, and level completion.
- `Assets/Scenes/` - Additional scene assets.
- `Assets/Prefabs/` - Reusable game objects including the end trigger and game manager.
- `Assets/Animation/` - Level completion animation assets.
- `Packages/` - Unity package dependencies.
- `ProjectSettings/` - Unity project and build settings.

## Opening the Project

1. Clone or download this repository.
2. Open Unity Hub.
3. Select **Open** and choose the project folder.
4. Use Unity `6000.6.0f1` when prompted.
5. Open `Assets/Menu.unity` and press Play.

Unity will regenerate local folders such as `Library/`, `Temp/`, and `Logs/`. These generated folders are excluded from Git.

## Uploading Changes

From the project folder, run:

```powershell
git add .gitignore README.md Assets Packages ProjectSettings
git commit -m "Add project documentation"
git push
```

Do not commit Unity-generated cache folders such as `Library/`, `Temp/`, or `Logs/`.
