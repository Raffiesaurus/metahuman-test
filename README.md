# MetaHuman Test

A **UE5.6 sandbox project** for exploring MetaHuman character integration with **Pixel Streaming 2** and **Live Link** facial animation. Tests real-time streaming of a MetaHuman character to a browser client, with AI-driven behaviour via StateTree.

> Personal research/exploration project - not a shipped product.

---

## What's Being Explored

- **MetaHuman character** setup and integration in UE5.6
- **MetaHuman Live Link** for real-time facial performance capture and animation
- **Pixel Streaming 2** to stream the rendered UE5 viewport to a web browser
- **StateTree / GameplayStateTree** for AI behaviour on the MetaHuman character
- **WebBrowserWidget** and **WebBrowserNativeProxy** for in-engine browser UI

---

## Plugins Enabled

| Plugin | Purpose |
|--------|---------|
| `MetaHuman` | Core MetaHuman support |
| `MetaHumanCharacter` | MetaHuman character rig and animation |
| `MetaHumanLiveLink` | Real-time facial animation via Live Link |
| `MetaHumanCoreTech` | Underlying MetaHuman processing tech |
| `MetaHumanDepthProcessing` | Depth-based facial processing |
| `PixelStreaming2` | Stream UE5 viewport to browser |
| `StateTree` / `GameplayStateTree` | AI behaviour trees |
| `WebBrowserWidget` | In-engine web UI |

---

## Tech

- **Engine:** Unreal Engine 5.6
- **Language:** C++ (`MetahumanTest` module) + Blueprints
- **Dependencies:** AIModule, UMG
- **Platforms:** Win64, Linux

---

## Opening the Project

1. Install **Unreal Engine 5.6** via the Epic Games Launcher
2. Clone the repo
3. Right-click `MetahumanTest.uproject` → **Generate Visual Studio project files**
4. Open the `.uproject` in UE5.6
5. MetaHuman assets need to be downloaded separately via **Quixel Bridge** inside the editor

> ⚠️ MetaHuman assets are not included in the repo due to size. You'll need to add your own via Bridge.

---

## License

MIT
