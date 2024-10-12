Skyward Quest Prototype Documentation
1. Project Overview
Project Name: Skyward Quest Prototype
Developer: Edward Mincham
Platform: PC (Unity Engine)
Genre: Action-Adventure

Skyward Quest is a 3D action-adventure prototype designed to explore platforming, puzzle-solving, and combat mechanics in a world of floating islands. The prototype includes player movement, elemental power abilities, and climbing mechanics.

2. Features Implemented
2.1. Player Movement
Horizontal Movement: Players can move using the WASD or Arrow keys.
Jumping: Press Spacebar to jump. The player can only jump when on the ground.
Smooth Camera Follow: The camera smoothly follows the player's movements.
2.2. Climbing Mechanic
Climbing: Players can climb designated objects (walls, ladders, etc.) by pressing C when in range. Gravity is disabled while climbing to allow vertical movement.
2.3. Elemental Powers System
Element Switching: Players can switch between Earth and Air elemental powers using the E key.
Earth Power: Currently serves as a placeholder for implementing a shield ability.
Air Power: Boosts player’s jump height when activated by pressing F.
2.4. User Interface
Current Element Display: The currently active elemental power is displayed on the screen using Unity’s UI system.
3. Controls
Action	Key
Move	WASD / Arrow Keys
Jump	Spacebar
Climb	C
Switch Element	E
Use Elemental Power	F
4. Setting Up the Project
4.1. System Requirements
Unity Version: 2021.3 or newer
Platform: PC
Dependencies: None
4.2. Importing the Project
Clone or Download: Clone the repository from GitHub or download it as a ZIP file.
Open in Unity: Open Unity Hub, click Open Project, and select the project folder.
Install Dependencies: Unity will automatically import any required assets.
4.3. Setting Up Git Version Control
.gitignore File: Make sure a .gitignore file is set up to ignore unnecessary files like Library/, Temp/, Obj/, etc.
GitHub Repository: Push your Unity project to GitHub for version control.
5. Scene Overview
5.1. Main Scene (MainScene)
Player Object: Includes a capsule representing the player, with Rigidbody, PlayerMovement, and ElementalPowers scripts attached.
Camera: The main camera has the CameraFollow script to follow the player's movement.
Environment: Includes basic platforms, obstacles, and climbable objects with the tag "Climbable".
5.2. Prefabs
Player Prefab: Contains all components for the player, including movement, climbing, and power scripts.
Climbable Prefab: A cube that represents climbable surfaces.
6. Scripts Breakdown
6.1. PlayerMovement.cs
Handles player movement including horizontal movement, jumping, and climbing.
Climbing Logic: Uses a trigger to determine when the player can start climbing and moves the player vertically while climbing.
6.2. ElementalPowers.cs
Element Switching: Switch between Earth and Air elemental powers.
Element Usage: Press F to activate the power of the currently selected element.
6.3. CameraFollow.cs
Smoothly follows the player while maintaining an offset.
Adjust the offset in the Inspector to control the camera's distance and angle relative to the player.
7. Known Issues
Player Sticking to Walls:
If the player sticks to walls while jumping, apply a Physics Material with zero friction to the player's collider.
Climbing Not Engaging:
Make sure the Climbable objects have a trigger collider, and the player has a Collider component attached.
8. Future Improvements
Add More Elemental Powers:
Implement more sophisticated powers for Earth, Air, Fire, and Water.
Advanced Climbing Mechanic:
Improve climbing interactions to include more fluid animations.
Combat System:
Add melee and ranged attacks with elemental effects.
Polished UI:
Implement a more visually appealing UI and a main menu.
9. Installation Instructions
Download Unity: Install Unity Hub and download Unity (2021.3 or newer recommended).
Clone Repository: Clone the project repository from GitHub.
Open Project: Launch Unity Hub and open the project folder.
10. Git Best Practices
Commit Often: Commit frequently to keep track of progress.
Use Branches: Create branches for new features or bug fixes.
Push Regularly: Push changes to GitHub to back up your progress.
Summary
The Skyward Quest Prototype is a starting point for an action-adventure game where players can move, jump, climb, and use elemental powers to explore their surroundings. This prototype provides core functionality, such as basic player movement, elemental power switching, and climbing mechanics, making it a good foundation for further game development.
