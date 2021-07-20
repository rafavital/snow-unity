# Snow Scene
This is a crude implementation of a snow scene I made in order to experiment with a snow shader using Unity's Shader Graph.

![](/Assets/Images/screenshot_1.png)
![](/Assets/Images/screenshot_2.png)
![](/Assets/Images/gif_1.gif)

## The Shader
The shader adds volume to the y component of the mesh based on a noise texture, the player has a Particle System attached to it which paints a render texture that is later used to reduce the added y volume in the mesh, creating the impression that the snowman is pushing it down.
![](/Assets/Images/graph_1.png)
