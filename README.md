# Unity First Simple Project Collection

<div align="center">

![Unity Version](https://img.shields.io/badge/Unity-6000.2.12f1-000000?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![License](https://img.shields.io/badge/License-CC0-green?style=for-the-badge)

**A comprehensive collection of Unity learning projects featuring 2D platformer mechanics and 3D character controller implementations**

[Features](#features) • [Projects](#projects-overview) • [Installation](#installation) • [Controls](#controls) • [Documentation](#technical-documentation)

</div>

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Projects Overview](#projects-overview)
  - [FirstTest - 2D Platformer Game](#1-firsttest---2d-platformer-game)
  - [NKDTrung - 3D Third-Person Adventure](#2-nkdtrung---3d-third-person-adventure)
  - [TaiNguyen - Asset Pack](#3-tainguyen---asset-pack)
- [Installation](#installation)
- [Controls](#controls)
- [Technical Documentation](#technical-documentation)
- [Project Structure](#project-structure)
- [Scripts Reference](#scripts-reference)
- [Assets & Credits](#assets--credits)
- [Development Setup](#development-setup)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

This repository contains a collection of Unity learning projects demonstrating fundamental game development concepts, including:

- **2D Platformer Mechanics**: Complete with player movement, jumping, collectibles, enemies, and win/lose conditions
- **3D Character Controllers**: Third-person camera systems, chunk-based terrain generation, and enemy AI
- **Audio Management**: Background music and sound effects systems
- **Game State Management**: Score tracking, game over/win states, scene management
- **UI Systems**: Menu systems, HUD elements with TextMeshPro

These projects serve as excellent learning resources for beginners and intermediate Unity developers looking to understand core game mechanics implementation.

---

## Features

### 2D Platformer Features
- **Smooth Character Movement** - WASD/Arrow keys with physics-based controls
- **Jump Mechanics** - Ground detection and variable jump force
- **Animated Character** - Idle, run, and jump animation states
- **Collectible System** - Coin collection with score tracking
- **Enemy AI** - Patrolling enemies with configurable movement patterns
- **Moving Platforms** - Parent-child attachment system for platform movement
- **Hazard Detection** - Traps and enemy collision handling
- **Win Condition** - Key collection system with victory screen
- **Audio System** - Background music and sound effects (jump, coin collection)
- **UI/UX** - Main menu, pause functionality, game over/win screens

### 3D Adventure Features
- **Third-Person Camera** - Mouse orbit controls with zoom functionality
- **3D Character Controller** - Physics-based movement with Rigidbody
- **Dynamic Terrain** - Chunk-based ground generation system
- **Enemy AI** - Chase mechanics with detection range
- **Animation System** - Speed-based animation blending

---

## Projects Overview

### 1. **FirstTest** - 2D Platformer Game

<img src="https://img.shields.io/badge/Genre-2D_Platformer-blue?style=flat-square" /> <img src="https://img.shields.io/badge/Status-Complete-success?style=flat-square" />

A fully functional 2D platformer game featuring classic side-scrolling gameplay mechanics. Players navigate through levels collecting coins, avoiding enemies and traps, and searching for the key to win.

#### Game Mechanics
- **Player Controls**: Left/Right movement, Jump
- **Objective**: Collect coins for score and find the key to win
- **Obstacles**: Enemies with patrol AI, static traps
- **Interactive Elements**: Moving platforms, collectibles
- **Progression**: Score-based system with game over/win conditions

#### Technical Implementation
- **PlayerController.cs**: Handles player input, movement physics, jump mechanics, and animation states
- **GameManager.cs**: Manages game state, score tracking, UI updates, scene transitions
- **PlayerCollision.cs**: Collision detection for collectibles, hazards, and win conditions
- **Enemy.cs**: Enemy patrol AI with boundary-based movement reversal
- **MovingPlatform.cs**: Platform movement between two points with player parenting
- **AudioManager.cs**: Centralized audio system for background music and sound effects
- **Menu.cs**: Main menu scene management and game initialization

#### Game Flow
```
Main Menu → Game Scene → (Collect Coins + Avoid Enemies) → Find Key → Victory Screen
                      ↓
                  Hit Enemy/Trap → Game Over Screen → Restart/Menu
```

---

### 2. **NKDTrung** - 3D Third-Person Adventure

<img src="https://img.shields.io/badge/Genre-3D_Adventure-purple?style=flat-square" /> <img src="https://img.shields.io/badge/Status-Prototype-yellow?style=flat-square" />

A 3D third-person game featuring camera controls, character movement, dynamic terrain generation, and enemy chase mechanics.

#### Core Systems
- **Camera System**: Mouse-controlled orbital camera with zoom
- **Movement System**: WASD controls with camera-relative direction
- **Terrain System**: Chunk-based infinite terrain generation
- **AI System**: Enemy detection and chase behavior

#### Technical Implementation
- **PlayerMotor.cs**: 3D character controller with Rigidbody physics, ground detection, and animation system
- **ThirdPerson.cs** (SimpleMouseOrbit): Third-person camera controller with mouse orbit, zoom, and target following
- **ChunkManager.cs**: Dynamic chunk loading/unloading based on player position (view distance optimization)
- **Ground.cs**: Large-scale grid-based ground generation for expansive worlds
- **AttackPlayer.cs** (EnemyChase): Enemy AI with player detection and pursuit mechanics

#### Features
- **Camera Controls**: 
  - Left Mouse Button + Drag to orbit
  - Mouse Wheel to zoom in/out
  - Auto-follow player with configurable offset
- **Movement System**: 
  - Camera-relative movement direction
  - Smooth character rotation towards movement direction
  - Ground detection for jump mechanics
- **Optimization**: Chunk-based rendering to maintain performance in large worlds

---

### 3. **TaiNguyen** - Asset Pack

<img src="https://img.shields.io/badge/Type-Asset_Library-orange?style=flat-square" />

A curated collection of game assets including sprites, sounds, and fonts sourced from various creators.

#### Contents
- **Sprites**: Knight character, slime enemy, platforms, coins, fruits, tilesets
- **Audio**: Sound effects and music tracks
- **Fonts**: Pixel Operator font family
- **License**: All assets under Creative Commons Zero (CC0)

---

## Installation

### Prerequisites
- **Unity Hub**: [Download here](https://unity.com/download)
- **Unity Editor**: Version **6000.2.12f1** (or compatible version)
- **Git**: For cloning the repository

### Setup Instructions

1. **Clone the Repository**
   ```bash
   git clone https://github.com/nkdtrung/Unity-FirstSimpleProject.git
   cd Unity-FirstSimpleProject
   ```

2. **Open in Unity Hub**
   - Launch Unity Hub
   - Click "Add" → "Add project from disk"
   - Navigate to one of the project folders:
     - `Unity-Final/FirstTest` (2D Platformer)
     - `Unity-Final/NKDTrung` (3D Adventure)
   - Select the folder and click "Open"

3. **Unity will automatically**:
   - Import all assets
   - Generate Library files
   - Compile scripts
   - Set up the project

4. **Open the Main Scene**:
   - **FirstTest**: Open `Assets/Scenes/Menu.unity` or `Assets/Scenes/Game.unity`
   - **NKDTrung**: Open the main scene in `Assets/Scenes/`

5. **Press Play** in the Unity Editor to test the game

---

## Controls

### 2D Platformer (FirstTest)

| Action | Keyboard | Description |
|--------|----------|-------------|
| **Move Left** | `A` or `←` | Move character left |
| **Move Right** | `D` or `→` | Move character right |
| **Jump** | `Space` or `W` | Jump (only when grounded) |
| **Start Game** | Mouse Click | Start from main menu |
| **Restart** | Mouse Click | Restart after game over |
| **Return to Menu** | Mouse Click | Return from game over/win screen |

### 3D Adventure (NKDTrung)

| Action | Input | Description |
|--------|-------|-------------|
| **Move Forward** | `W` | Move character forward |
| **Move Backward** | `S` | Move character backward |
| **Move Left** | `A` | Strafe left |
| **Move Right** | `D` | Strafe right |
| **Jump** | `Space` | Jump (when grounded) |
| **Rotate Camera** | `Left Mouse + Drag` | Orbit camera around player |
| **Zoom** | `Mouse Wheel` | Zoom camera in/out |

---

## Technical Documentation

### System Architecture

#### 2D Platformer Architecture
```
GameManager (Singleton Pattern)
    ├── Score Management
    ├── Game State Control (Play/GameOver/Win)
    ├── UI Management (TextMeshPro)
    └── Scene Management
    
PlayerController
    ├── Input Handler (Horizontal Movement)
    ├── Physics Controller (Rigidbody2D)
    ├── Jump Mechanics (Ground Check)
    └── Animation Controller
    
AudioManager
    ├── Background Music (Looping)
    └── Sound Effects (OneShot)
```

#### 3D Adventure Architecture
```
PlayerMotor (Character Controller)
    ├── Input System (WASD)
    ├── Physics System (Rigidbody)
    ├── Ground Detection (Sphere Check)
    └── Animation Controller (Speed-based)
    
ThirdPersonCamera
    ├── Mouse Input Handler
    ├── Orbit Calculations
    └── Zoom Controls
    
ChunkManager (Optimization)
    ├── Player Position Tracking
    ├── Chunk Loading/Unloading
    └── View Distance Management
```

### Key Design Patterns Used

1. **Singleton Pattern**: GameManager ensures single instance for game state
2. **Component Pattern**: MonoBehaviour components for modular functionality
3. **Observer Pattern**: UI updates based on score changes
4. **Object Pooling**: (Potential) Coin and enemy instantiation
5. **State Machine**: Game states (Playing, GameOver, Win)

---

## Project Structure

```
Unity-FirstSimpleProject/
│
├── README.md                          # This file
├── .gitignore                         # Git ignore rules (Unity-specific)
│
└── Unity-Final/
    │
    ├── FirstTest/                     # 2D Platformer Project
    │   ├── Assets/
    │   │   ├── Animations/            # Player & enemy animation clips
    │   │   ├── Audio/                 # Background music & sound effects
    │   │   │   ├── Coin.wav
    │   │   │   ├── Jump.wav
    │   │   │   └── MusicBackGround.mp3
    │   │   ├── Fonts/                 # UI fonts (TextMeshPro)
    │   │   ├── Prefabs/               # Reusable game objects
    │   │   │   ├── Coin.prefab
    │   │   │   ├── Enemy.prefab
    │   │   │   ├── Key.prefab
    │   │   │   ├── Trap.prefab
    │   │   │   └── MovingPlatform.prefab
    │   │   ├── Scenes/                # Game scenes
    │   │   │   ├── Menu.unity         # Main menu scene
    │   │   │   └── Game.unity         # Gameplay scene
    │   │   ├── Scripts/               # C# game logic
    │   │   │   ├── PlayerController.cs      # Player movement & input
    │   │   │   ├── PlayerCollision.cs       # Collision detection
    │   │   │   ├── GameManager.cs           # Game state & score
    │   │   │   ├── Enemy.cs                 # Enemy patrol AI
    │   │   │   ├── MovingPlatform.cs        # Platform movement
    │   │   │   ├── AudioManager.cs          # Sound system
    │   │   │   └── Menu.cs                  # Menu functionality
    │   │   ├── Sprites/               # 2D graphics assets
    │   │   │   ├── Player_Idle.png
    │   │   │   ├── Player_Run.png
    │   │   │   ├── Player_Jump.png
    │   │   │   ├── Coin.png
    │   │   │   ├── Enemy.png
    │   │   │   ├── Key.png
    │   │   │   ├── Trap.png
    │   │   │   ├── platforms.png
    │   │   │   ├── Map.png
    │   │   │   └── borders.png
    │   │   ├── Tile/                  # Tilemap assets (if used)
    │   │   └── Settings/              # Project settings
    │   ├── ProjectSettings/           # Unity project configuration
    │   └── Packages/                  # Package Manager dependencies
    │
    ├── NKDTrung/                      # 3D Third-Person Project
    │   ├── Assets/
    │   │   ├── Scripts/
    │   │   │   ├── PlayerMotor.cs            # 3D character controller
    │   │   │   ├── ThirdPerson.cs            # Camera orbit system
    │   │   │   ├── ChunkManager.cs           # Dynamic terrain
    │   │   │   ├── Ground.cs                 # Ground generation
    │   │   │   ├── AttackPlayer.cs           # Enemy chase AI
    │   │   │   └── DuplicateGround.cs        # Ground utilities
    │   │   ├── Scenes/                       # 3D game scenes
    │   │   └── TutorialInfo/                 # Unity tutorial assets
    │   ├── ProjectSettings/
    │   └── Packages/
    │
    └── TaiNguyen/                     # Shared Asset Pack
        ├── LICENSE & CREDITS.txt      # Asset attribution
        ├── Sprites/                   # Original sprite sheets
        │   ├── Player_Idle.png
        │   ├── Player_Run.png
        │   ├── Player_Jump.png
        │   ├── Coin.png
        │   ├── Enemy.png
        │   ├── Key.png
        │   ├── Trap.png
        │   ├── platforms.png
        │   ├── Map.png
        │   ├── borders.png
        │   └── PixelOperator8.ttf     # Pixel font
        └── Sound/                      # Audio files
```

### Important Files & Folders

| Path | Description |
|------|-------------|
| `Assets/Scenes/` | Contains Unity scene files (levels) |
| `Assets/Scripts/` | All C# game logic and behavior scripts |
| `Assets/Prefabs/` | Reusable game objects (enemies, collectibles, etc.) |
| `Assets/Sprites/` | 2D graphics and sprite sheets |
| `Assets/Audio/` | Background music and sound effects |
| `ProjectSettings/` | Unity project configuration (rendering, physics, input, etc.) |
| `Library/` | Generated Unity cache files (NOT in Git) |
| `Temp/` | Temporary build files (NOT in Git) |

---

## Scripts Reference

### FirstTest (2D Platformer)

#### **PlayerController.cs**
```csharp
// Core player movement and input handling
[SerializeField] private float moveSpeed = 5f;        // Horizontal movement speed
[SerializeField] private float jumpForce = 15f;       // Jump force magnitude
[SerializeField] private LayerMask groundLayer;       // Ground detection layer
[SerializeField] private Transform groundCheck;       // Ground check position
```

**Key Methods**:
- `HandleMovement()`: Processes horizontal input and applies velocity
- `HandleJump()`: Checks ground state and applies jump force
- `updateAnimation()`: Updates animator parameters based on velocity

**Features**:
- Horizontal movement with Rigidbody2D physics
- Ground detection using OverlapCircle
- Character flipping based on movement direction
- Integration with GameManager for game state checks

---

#### **GameManager.cs**
```csharp
// Singleton game state manager
private int score = 0;                               // Current player score
[SerializeField] private TextMeshProUGUI scoreText; // UI score display
[SerializeField] private GameObject gameOverUi;     // Game over panel
[SerializeField] private GameObject gameWinUI;      // Victory panel
```

**Key Methods**:
- `AddScore(int points)`: Increments score and updates UI
- `gameOver()`: Triggers game over state and pauses game
- `GameWin()`: Triggers victory state
- `RestartGame()`: Reloads current scene and resets state
- `gotoMenu()`: Returns to main menu scene

**Responsibilities**:
- Score tracking and display
- Game state management (Playing/GameOver/Win)
- UI panel visibility control
- Scene loading and time scale management

---

#### **PlayerCollision.cs**
```csharp
// Trigger-based collision detection
private void OnTriggerEnter2D(Collider2D collision)
```

**Collision Handling**:
- `"Coin"`: Destroys coin, plays sound, adds score
- `"Trap"`: Triggers game over
- `"Enemy"`: Triggers game over
- `"Key"`: Destroys key, triggers win condition

**Requirements**: Colliders must have "Is Trigger" enabled

---

#### **Enemy.cs**
```csharp
// Patrol-based enemy AI
[SerializeField] private float moveSpeed = 3f;       // Movement speed
[SerializeField] private float distance = 5f;        // Patrol distance
```

**Behavior**:
- Moves left/right within defined patrol range
- Automatically flips sprite when changing direction
- Uses `startPos` as patrol center point
- Boundary-based direction reversal

---

#### **MovingPlatform.cs**
```csharp
// Platform movement with player attachment
[SerializeField] private Transform pointA;           // Start position
[SerializeField] private Transform pointB;           // End position
[SerializeField] private float speed = 2f;           // Movement speed
```

**Features**:
- Moves smoothly between two Transform points
- Automatically sets player as child on collision (moves player with platform)
- Detaches player when leaving platform
- Uses `Vector3.MoveTowards` for smooth interpolation

---

#### **AudioManager.cs**
```csharp
// Centralized audio control system
[SerializeField] private AudioSource backgroundAudioSource;  // Music channel
[SerializeField] private AudioSource effectAudioSource;      // SFX channel
```

**Audio Channels**:
- Background music (looping)
- Sound effects (one-shot)

**Methods**:
- `PlayBackgroundMusic()`: Starts looping background music
- `PlayCoinSound()`: Plays coin collection SFX
- `PlayJumpSound()`: Plays jump SFX

---

#### **Menu.cs**
```csharp
// Main menu scene controller
public void StartGame()    // Loads "Game" scene
public void QuitGame()     // Exits application
```

---

### NKDTrung (3D Adventure)

#### **PlayerMotor.cs**
```csharp
// 3D character controller with Rigidbody physics
[SerializeField] private float moveSpeed = 4f;              // Movement speed
[SerializeField] private float jumpForce = 5f;              // Jump force
[SerializeField] private Transform groundCheck;             // Ground check position
[SerializeField] private float groundCheckRadius = 0.25f;   // Ground detection radius
[SerializeField] private LayerMask groundMask;              // Ground layer
```

**Key Features**:
- Camera-relative movement (WASD moves relative to camera direction)
- Smooth character rotation towards movement direction
- Ground detection using `Physics.CheckSphere`
- Rigidbody constraints to prevent physics rotation
- Animation speed parameter based on velocity magnitude

**Physics Configuration**:
- Freezes rotation on all axes (prevents tipping)
- Uses `CollisionDetectionMode.Continuous` for fast-moving objects
- Angular damping set to 6 for rotation stability
- Interpolation enabled for smooth movement

---

#### **ThirdPerson.cs** (SimpleMouseOrbit)
```csharp
// Third-person camera controller with orbit and zoom
[SerializeField] private Transform target;              // Player to follow
[SerializeField] private float distance = 5.0f;         // Current camera distance
[SerializeField] private float minDistance = 2.0f;      // Minimum zoom distance
[SerializeField] private float maxDistance = 12.0f;     // Maximum zoom distance
[SerializeField] private float xSpeed = 300.0f;         // Horizontal rotation speed
[SerializeField] private float ySpeed = 5.0f;           // Vertical rotation speed
[SerializeField] private float yMinLimit = -80f;        // Minimum vertical angle
[SerializeField] private float yMaxLimit = 80f;         // Maximum vertical angle
```

**Controls**:
- **Left Mouse Button + Drag**: Orbit camera around target
- **Mouse Wheel**: Zoom in/out (clamped to min/max distance)
- Camera always looks at target position
- Y-axis rotation clamped to prevent camera flipping

**Implementation**:
- Uses Quaternion rotation for smooth camera movement
- Calculates camera position using spherical coordinates
- Updates in `LateUpdate()` to ensure smooth following

---

#### **ChunkManager.cs**
```csharp
// Dynamic chunk-based terrain system
[SerializeField] private GameObject groundPrefab;        // Ground tile prefab
[SerializeField] private int chunkSize = 16;             // Size of each chunk
[SerializeField] private int chunkViewDistance = 3;      // Chunks visible around player
[SerializeField] private Transform player;               // Player transform
```

**Optimization System**:
- Loads/unloads chunks based on player position
- Only renders chunks within `chunkViewDistance` range
- Uses Dictionary for efficient chunk lookup
- Deactivates far chunks instead of destroying (object pooling)
- Updates every frame to track player movement

**How It Works**:
1. Calculates player's current chunk coordinate
2. Loads all chunks within view distance
3. Deactivates chunks outside view distance
4. Instantiates new chunks if needed

---

#### **Ground.cs** (GroundGridGenerator)
```csharp
// Large-scale grid-based ground generation
[SerializeField] private GameObject groundPrefab;    // Ground tile prefab
[SerializeField] private int gridX = 1000;           // Grid width
[SerializeField] private int gridZ = 1000;           // Grid depth
[SerializeField] private float spacing = 5f;         // Space between tiles
```

**Use Case**: Generates massive ground grids at game start (alternative to ChunkManager)

---

#### **AttackPlayer.cs** (EnemyChase)
```csharp
// Enemy AI with player detection and pursuit
[SerializeField] private Transform player;           // Player to chase
[SerializeField] private float detectRange = 8f;     // Detection radius
[SerializeField] private float moveSpeed = 2f;       // Chase speed
```

**AI Behavior**:
- Calculates distance to player each frame
- Activates chase when player enters `detectRange`
- Moves towards player using normalized direction vector
- Smoothly rotates to face player using `Quaternion.Slerp`

---

## Assets & Credits

### Asset Attribution

All assets used in these projects are under **Creative Commons Zero (CC0)** license, allowing free use without attribution (though credit is appreciated).

#### Sprites

| Asset | Creator | Source |
|-------|---------|--------|
| **Knight Character** | analogStudios_ | [Camelot Pack](https://analogstudios.itch.io/camelot) |
| **Slime Enemy** | analogStudios_ | [Dungeon Sprites](https://analogstudios.itch.io/dungeonsprites) |
| **Platforms & Coin** | analogStudios_ | [Four Seasons Platformer](https://analogstudios.itch.io/four-seasons-platformer-sprites) |
| **World Tileset & Fruit** | RottingPixels | [Four Seasons Tileset](https://rottingpixels.itch.io/four-seasons-platformer-tileset-16x16free) |

#### Audio
- **Sound Effects**: Created by Brackeys & Asbjørn Thirslund
- **Background Music**: Composed by Brackeys & Sofia Thirslund

#### Fonts
- **Pixel Operator**: Created by Jayvee Enaguas (HarvettFox96)
  - [Download Link](https://www.dafont.com/pixel-operator.font?l[]=10&l[]=1)

### Asset Modifications
Many assets have been repackaged and modified by **Brackeys** for educational purposes.

---

## Development Setup

### Unity Configuration

#### Package Dependencies
Both projects use Unity's Package Manager for dependencies. Common packages include:
- **TextMeshPro**: Enhanced UI text rendering
- **2D Sprite**: 2D rendering features (FirstTest)
- **Input System** (optional): New input handling system
- **Cinemachine** (optional): Advanced camera controls

To install packages:
1. Open Unity Editor
2. Go to **Window → Package Manager**
3. Search and install required packages

#### Input Manager Settings
The projects use Unity's legacy Input Manager:
- **Horizontal**: A/D or Arrow Left/Right
- **Vertical**: W/S or Arrow Up/Down
- **Jump**: Space (mapped to "Jump" button)
- **Mouse X/Y**: Mouse movement axes

#### Physics Settings

**2D Platformer (FirstTest)**:
- **Gravity Scale**: -9.81 (downward gravity)
- **Ground Layer**: Separate layer for ground detection
- **Collision Matrix**: Player vs Ground, Player vs Enemies/Traps

**3D Adventure (NKDTrung)**:
- **Ground Layer**: Dedicated layer for ground detection
- **Collision Detection**: Continuous mode for player Rigidbody
- **Physics Materials**: (Optional) For friction control

#### Tags Setup
Ensure the following tags are created in **Edit → Project Settings → Tags and Layers**:

**FirstTest (2D)**:
- `Player`
- `Coin`
- `Trap`
- `Enemy`
- `Key`
- `Ground`

**NKDTrung (3D)**:
- `Player`
- `Ground`
- `Enemy`

---

## Building the Game

### Build Instructions

1. **Open Build Settings**:
   - Go to **File → Build Settings**

2. **Add Scenes**:
   - For FirstTest: Add `Menu.unity` and `Game.unity`
   - Ensure Menu scene is Scene 0 (first in list)

3. **Select Platform**:
   - **PC/Mac/Linux Standalone**: For desktop builds
   - **WebGL**: For browser-based games
   - **Android/iOS**: For mobile platforms

4. **Player Settings**:
   - Set **Company Name** and **Product Name**
   - Configure **Icon** and **Splash Screen**
   - Set **Resolution** and **Quality** settings

5. **Build**:
   - Click **Build** or **Build and Run**
   - Choose output folder

### Build Settings Recommendations

**For WebGL**:
- **Compression Format**: Gzip or Brotli
- **Memory Size**: 512MB+
- **Enable Exceptions**: None (for smaller build size)

**For Standalone**:
- **Architecture**: x86_64 (64-bit)
- **Fullscreen Mode**: Fullscreen Window
- **Default Resolution**: 1920x1080

---

## Learning Resources

### Topics Covered in These Projects

#### Beginner Concepts
- Unity Editor basics (Scene, Game, Inspector views)
- GameObject and Component system
- MonoBehaviour lifecycle (Awake, Start, Update, FixedUpdate)
- Input handling (GetAxis, GetButton)
- Transform manipulation (position, rotation, scale)
- Basic physics (Rigidbody2D, Rigidbody)
- Collision detection (OnTriggerEnter2D, OnCollisionEnter2D)

#### Intermediate Concepts
- Animation system (Animator, Animation Clips)
- Prefab workflow and instantiation
- Scene management (SceneManager)
- UI system (Canvas, TextMeshPro)
- Audio management (AudioSource, AudioClip)
- Parent-child object relationships
- Layer-based collision filtering

#### Advanced Concepts
- Game state management (Singleton pattern)
- Camera systems (follow, orbit, zoom)
- Procedural generation (chunk-based terrain)
- AI programming (patrol, chase behaviors)
- Performance optimization (object pooling, chunk loading)
- Vector mathematics (distance, direction, magnitude)

### Recommended Next Steps

1. **Expand the 2D Platformer**:
   - Add multiple levels
   - Implement health system
   - Create different enemy types
   - Add power-ups and abilities
   - Implement save/load system

2. **Enhance the 3D Adventure**:
   - Add combat system
   - Implement inventory system
   - Create quest/mission system
   - Add NPCs and dialogue
   - Implement day/night cycle

3. **Learn New Systems**:
   - Particle effects (VFX)
   - Shader programming
   - Multiplayer networking
   - Advanced AI (behavior trees, state machines)
   - Procedural content generation

### Useful Unity Resources
- **Official Documentation**: [docs.unity3d.com](https://docs.unity3d.com/)
- **Unity Learn**: [learn.unity.com](https://learn.unity.com/)
- **Brackeys YouTube**: Classic Unity tutorials (archived)
- **Unity Forums**: [forum.unity.com](https://forum.unity.com/)

---

## Known Issues & Troubleshooting

### Common Issues

#### Issue: Player falls through ground
**Solution**: 
- Check ground LayerMask in PlayerController/PlayerMotor
- Ensure ground has appropriate Collider component
- Verify Collision Matrix in Physics settings

#### Issue: Jump not working
**Solution**:
- Check if `groundCheck` Transform is assigned
- Verify `groundLayer` LayerMask is set correctly
- Ensure ground objects are on correct layer

#### Issue: Audio not playing
**Solution**:
- Check if AudioManager is in the scene
- Verify AudioClips are assigned in Inspector
- Check audio mixer volume settings
- Ensure AudioSource components are not muted

#### Issue: UI not updating
**Solution**:
- Verify GameManager is in the scene
- Check TextMeshPro references in Inspector
- Ensure Canvas is set to "Screen Space - Overlay"

#### Issue: Camera not following player
**Solution** (3D):
- Check if `target` Transform is assigned
- Verify camera script is enabled
- Check LateUpdate execution order

#### Issue: Build size too large
**Solution**:
- Remove unused assets from project
- Compress textures (Sprite Import Settings)
- Use audio compression (AudioClip Import Settings)
- Disable debug logging in builds

---

## Contributing

Contributions are welcome! This project is designed for learning, so improvements, bug fixes, and new features are appreciated.

### How to Contribute

1. **Fork the Repository**
   ```bash
   git clone https://github.com/YOUR_USERNAME/Unity-FirstSimpleProject.git
   ```

2. **Create a Feature Branch**
   ```bash
   git checkout -b feature/YourFeatureName
   ```

3. **Make Your Changes**
   - Follow existing code style
   - Add comments for complex logic
   - Test thoroughly in Unity Editor

4. **Commit Your Changes**
   ```bash
   git add .
   git commit -m "Add: Description of your feature"
   ```

5. **Push to Your Fork**
   ```bash
   git push origin feature/YourFeatureName
   ```

6. **Create a Pull Request**
   - Go to the original repository
   - Click "New Pull Request"
   - Describe your changes in detail

### Contribution Guidelines

- Follow Unity C# coding conventions
- Comment complex algorithms
- Test all changes before submitting
- Update README if adding new features
- Keep commits focused and descriptive
- Don't commit Library/ or Temp/ folders
- Don't include large binary files without reason

### Code Style

```csharp
// Use clear, descriptive variable names
[SerializeField] private float jumpForce = 10f;

// Add XML documentation for public methods
/// <summary>
/// Adds points to the player's score
/// </summary>
/// <param name="points">Number of points to add</param>
public void AddScore(int points)
{
    score += points;
    UpdateScore();
}

// Use regions for organization (optional)
#region Movement Methods
private void HandleMovement() { }
private void HandleJump() { }
#endregion
```

---

## License

### Project License
This project is released under the **MIT License** (or specify your preferred license).

### Asset Licenses
All game assets (sprites, sounds, fonts) are under **Creative Commons Zero (CC0)**, allowing:
- Commercial use
- Modification
- Distribution
- Private use
- No warranty provided

See [LICENSE & CREDITS.txt](Unity-Final/TaiNguyen/LICENSE%20&%20CREDITS.txt) for detailed asset attribution.

---

## Acknowledgments

Special thanks to:
- **Unity Technologies** - For the amazing game engine
- **Brackeys** - For inspiring countless game developers with excellent tutorials
- **analogStudios_** - For beautiful sprite assets
- **RottingPixels** - For versatile tileset graphics
- **Jayvee Enaguas (HarvettFox96)** - For the Pixel Operator font
- **The Unity Community** - For continuous support and knowledge sharing

---

## Contact & Support

- **Repository**: [github.com/nkdtrung/Unity-FirstSimpleProject](https://github.com/nkdtrung/Unity-FirstSimpleProject)
- **Issues**: [Report bugs or request features](https://github.com/nkdtrung/Unity-FirstSimpleProject/issues)
- **Discussions**: [Ask questions or share ideas](https://github.com/nkdtrung/Unity-FirstSimpleProject/discussions)

---

## Project Roadmap

### Completed
- [x] Basic 2D platformer mechanics
- [x] Player animation system
- [x] Collectible and scoring system
- [x] Enemy patrol AI
- [x] Moving platforms
- [x] Audio system
- [x] UI/Menu system
- [x] 3D character controller
- [x] Third-person camera
- [x] Chunk-based terrain generation
- [x] Enemy chase AI

### Planned Features
- [ ] Add multiple levels/stages
- [ ] Implement health system
- [ ] Create checkpoint system
- [ ] Add power-ups and abilities
- [ ] Implement particle effects
- [ ] Add more enemy types
- [ ] Create boss battles
- [ ] Implement save/load system
- [ ] Add achievement system
- [ ] Mobile touch controls

### Future Improvements
- [ ] Rewrite using new Input System
- [ ] Implement object pooling
- [ ] Add more camera modes
- [ ] Create level editor
- [ ] Add multiplayer support
- [ ] Integrate analytics
- [ ] Add localization support

---

<div align="center">

### If this project helped you learn Unity, please consider giving it a star!

**Made with love by Unity Learners**

[Back to Top](#unity-first-simple-project-collection)

</div>