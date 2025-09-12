# Copilot Instructions for The Last Signal

## Project Overview
- **The Last Signal** is a Unity 2D game project using C# scripts, the Universal Render Pipeline, and Unity's new Input System.
- Core gameplay logic is in `Assets/Scripts/`. Key interfaces and components include:
  - `IInteractable`: Interface for objects the player can interact with.
  - `InteractionDetector`: Handles player proximity and interaction logic.
  - `ControlPanel`: Example interactable implementing `IInteractable`.
  - `PlayerMovement`: Handles player movement using Unity's physics and input.
- Input actions are defined in `Assets/InputSystem_Actions.inputactions` (use Unity's Input System package).

## Architecture & Patterns
- **Interaction Pattern**: Objects implement `IInteractable` (with `Interact()` and `CanInteract()`). `InteractionDetector` manages a list of nearby interactables and triggers interaction on input.
- **Player Movement**: Controlled via `PlayerMovement` using `Rigidbody2D` and input axes.
- **Input System**: Use the Input System package (`com.unity.inputsystem`). Actions are mapped in the `.inputactions` asset, not hardcoded.
- **Component Model**: All gameplay logic is attached to GameObjects as MonoBehaviours.

## Developer Workflows
- **Build**: Use Unity Editor (no custom build scripts detected).
- **Test**: No custom test scripts found; use Unity Test Framework if needed.
- **Debug**: Use `Debug.Log` for runtime diagnostics (see scripts for examples).
- **Dependencies**: Managed via `Packages/manifest.json`. Key packages: 2D tools, Input System, URP, Visual Scripting.

## Conventions & Tips
- **Scripts**: Place new scripts in `Assets/Scripts/`. Use interfaces for extensibility.
- **Input**: Add new actions in `InputSystem_Actions.inputactions` and bind in code via Input System APIs.
- **Scene/Prefab Organization**: Scenes, prefabs, and assets are under `Assets/` subfolders.
- **Logging**: Use `Debug.Log` for traceability during interactions and state changes.

## Integration Points
- **Unity Packages**: See `Packages/manifest.json` for all dependencies.
- **Input System**: Integrate new controls via the `.inputactions` asset and update scripts accordingly.

## Examples
- To add a new interactable, implement `IInteractable` and attach to a GameObject.
- To handle new input, update `InputSystem_Actions.inputactions` and reference the action in your script.

---
For more details, review the scripts in `Assets/Scripts/` and the input actions asset. Update this file as the project evolves.