# xMaze
Oculus Rift DK2 Maze solving game made with Unity3D 4.6.1

### Instructions
You, Cyclops, are faced with an unsolvable maze. Use your mutation to create paths where there are none and find your way to the treasure that awaits at the end of the maze. In other words, certain parts of the maze are breakable using the laser beams you shoot out of your eyes.

Import the whole project into Unity and run the Scene Maze1.unity with the DK2 in Extended mode. Drag the Game view onto your HMD screen.

### Controls:

- Movement: W, A, S, D
- Mouse: Look around
- DK2: Also, look around
- Fire laser beam from eye: LCtrl

### Prefabs:
- Cyclops: Added laser beam firing functionality using LineRenderers to the basic OVRPlayerController prefab
- Wall: Single wall object. Simply a Scaled version of the Destructible Crate Asset, sans the destructibility
- DestWall: Scaled version of Destructible Crate Asset

### Issues/To-Do:
- The laser beam, made of linerenderers does not display correctly in the build. The color and with are still default. Whereas Playing in unity gives a translucent red beam of appropriate width.
- Laser still passes through certain parts of the maze i.e. corners of cells. This is because I had to reduce the collider size to 0.95 times of the wall length. Using a custom collider (trapezoid in shape) would be a better solution (for the current case of a hexagonal maze) that doesn't cause the maze to collapse.
- Structurally, I should consider making the maze from more appropriate building blocks and colliders.
- Use better assets.

### Assets used:
- Floor, SkyBox from Mecanim-GDC2013 (Unity Asset Store)
- Destructible Crate Asset from Unity Asset Store
- Treasure Chest Asset from Unity Asset Store
