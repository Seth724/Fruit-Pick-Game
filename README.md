# 🍎 Fruit Pick Game

A fun and engaging 2D Unity game where players control a basket to catch falling fruits and earn points!

## 📖 Game Overview

Fruit Pick Game is a classic arcade-style game built in Unity where the player controls a basket at the bottom of the screen to catch falling fruits. The objective is to catch as many fruits as possible while avoiding letting them hit the ground, which reduces your lives.

## 🎮 Gameplay Features

- **Simple Controls**: Use arrow keys or A/D keys to move the basket left and right
- **Multiple Fruit Types**: Various fruit prefabs (Apple 1, Apple 2, Apple 3, and more)
- **Life System**: Start with 5 lives - lose a life each time a fruit hits the ground
- **Score System**: Earn points for each fruit caught
- **Game Over Screen**: Restart functionality when all lives are lost
- **Main Menu**: Clean UI with play button to start the game

## 🕹️ How to Play

1. **Start the Game**: Click the "Play" button on the main menu
2. **Move the Basket**: Use the arrow keys (← →) or A/D keys to move your basket
3. **Catch Fruits**: Position your basket under falling fruits to catch them
4. **Avoid Missing**: Don't let fruits hit the ground or you'll lose a life
5. **Survive**: Keep catching fruits to increase your score and survive as long as possible
6. **Game Over**: When you run out of lives, you can restart and try again

## 🏗️ Project Structure

### Scripts
- **`GameManager.cs`** - Core game logic, handles score, lives, and game over state
- **`BasketController.cs`** - Player basket movement and fruit collision detection
- **`Fruit.cs`** - Fruit behavior including destruction when hitting ground
- **`SpawnManager.cs`** - Handles spawning fruits at random positions and intervals
- **`UIManager.cs`** - Manages UI elements using UI Toolkit (score, lives, game over screen)
- **`MainMenu.cs`** - Main menu functionality and scene transitions

### Scenes
- **MainMenu** - Initial game screen with play button
- **Gameplay** - Main game scene where the action happens
- **UI** - Dedicated UI testing scene

### Assets
- **Prefabs**: Multiple fruit variants (Apple 1, Apple 2, Apple 3, Apple)
- **Sprites**: Fruit textures and UI elements
- **UI Toolkit**: Modern Unity UI system for responsive interface

## 🛠️ Technical Details

- **Unity Version**: 6000.2.14f1
- **Rendering Pipeline**: Universal Render Pipeline (URP)
- **Input System**: Unity's legacy Input Manager
- **UI Framework**: UI Toolkit for modern, performant UI
- **Physics**: Unity 2D Physics for collision detection

### Key Features
- **Object Pooling**: Efficient fruit spawning and destruction
- **Boundary Clamping**: Basket movement constrained to screen boundaries
- **Timer System**: Uses `InvokeRepeating` for consistent fruit spawning
- **Scene Management**: Smooth transitions between menu and gameplay

## 📋 Requirements

- Unity 2022.3 LTS or newer (recommended)
- Universal Render Pipeline
- Input System package (legacy input)
- UI Toolkit package

## 🚀 Setup Instructions

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/Seth724/Fruit-Pick-Game.git
   ```

2. **Open in Unity**:
   - Launch Unity Hub
   - Click "Open" and select the `Fruit-Pick-Game` folder
   - Unity will automatically import all assets

3. **Build Settings**:
   - Add scenes in this order:
     1. MainMenu
     2. Gameplay
   - Set target platform as desired

4. **Play**:
   - Press Play in Unity Editor, or
   - Build and run for your target platform

## 🎯 Game Mechanics

### Scoring System
- **+1 point** for each fruit caught
- Score displays in real-time during gameplay
- Final score shown on game over screen

### Life System
- Start with **5 lives**
- Lose **1 life** when a fruit hits the ground
- Game ends when lives reach 0

### Spawn System
- Fruits spawn at random X positions across the top of the screen
- Configurable spawn rate and timing
- Multiple fruit types for visual variety

## 🔧 Customization

### Adjustable Parameters
- **Basket Speed**: Modify `moveSpeed` in `BasketController`
- **Spawn Rate**: Adjust `repeatRate` in `SpawnManager`
- **Fruit Fall Speed**: Modify gravity in Physics2D settings
- **Lives Count**: Change initial `life` value in `GameManager`
- **Spawn Range**: Adjust `spawnRangeX` in `SpawnManager`

## 🐛 Known Issues

- Main menu button registration needs optimization (currently registers in Update)
- Some variable naming could be improved (e.g., "distroyPossition" typo)

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test thoroughly
5. Submit a pull request

## 📝 License

This project is open source. Feel free to use and modify for learning purposes.

## 👨‍💻 Developer

Created by [Seth724](https://github.com/Seth724)

---

**Enjoy playing Fruit Pick Game! 🍎🎮**
