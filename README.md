
## Quick VR setup for assessment

Start brainstorming on some names:
- Cloud seeding
- Rise of the plants of the ..
- Botanic Commando.

With Botanic Commando in mind (because I worked on Bionic Commando as 3D artist a long time ago) I made some concepts with Midjourney. I also did the environment skybox with Midjourney.
<img width="1024" height="1024" alt="image" src="https://github.com/user-attachments/assets/500b836e-de20-4941-af69-66de46ab51c3" />

I wanted to do a modular setup based on scriptable objects so I started with that set-up, I imagined to have 3 sorts of influences : water, light and food that would affect the growth rate. 
Only having a couple of hours (5) to do the assessment I went the quick and dirty route. 
- I made the 3D models in Blender.
- I use a trigger with a simple box collider to trigger object changes. (A nicer approach would be to do a raycast or use particle collisions)
- I made the textures with substance sampler and used seedpack images from google, I used 1 mud texture from my archive.

## Test instructions
- The user can plant a seed by holding the seed package over a flower pot for a certain amount of time (grab button with controllers).
- The user can grow the plant by watering it for a certain amount of time.
- The user can reset the scene by interacting with the big blue button.
  
## Improvements
- Implement the condition reaction system I prepared.
- Raycasting for tool interaction
- full 3D scene with proper collision objects.
- Tutorial for a user
- Implement more influences : light, food, descreasing water levels, overkill of light, water and food etc.
