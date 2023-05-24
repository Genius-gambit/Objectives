## Objectives  :notebook_with_decorative_cover:(11 May 2023~)

1. - [x] Import the environment, 3D models for the project.
2. - [x] Place Cubes to make the track for the plane.
3. - [x] Create AircraftController.cs for the Engine component.
4. - [x] Assign one cube at a time.
5. - [x] Finish the runway.
6. - [x] Create 22 images and Import the images in the environment for the runway.
7. - [x] Implement Final Message when the activity is over.
8. - [x] Implement Intro Control UI Image before the start of the activity.
9. - [x] Import the images in the environment for the runway.
10. - [x] Finish the Animation Controller for the Introbanner.
11. - [ ] Implement Voice Overs and Sound of the airplane.

## Work Log
1. Created Tracking.cs, which takes the cube and indicates the trigger if it hit the track in order to rotate the plane.
2. index = 1: to rotate left for the plane.
3. index = 2: to stop rotation.
4. index = 3: to turn y-angle to 180.
5. index = 4: to turn right.
6. Box Triggers can help to pop up 3D Canvas for the information for the User.
7. Created 2 tags for the colliders- InfoTag, Track. InfoTag is to print the 3D Canvas and Track is for the aircraft to turn left or right.
8. 16 Images done.
9. Placed 21 images in the game applications for UI.
10. Created Animation Controller for the IntroBanner.
11. Debugging the runway model.

## Summary
1. Imported Airport Environment and Aircraft asset in the main Scene.
2. Created box trigger and attached on top the aircraft.
3. Created multiple box triggers to make a track for the runway.
4. Created Aircraft Controller Script which handles the input systems of VR and Keyboard events.
5. Created a Dictionary which has int as the key and functions / methods as it's value.
6. Created 22 images and imported onto the environment.
7. Created Tracking script which handles two types of the situations for the box triggers.
    1. If collides with the gameobject which has the tag "InfoTag", It indicates that UI image will set active.
    2. If collides with the gameobject which has the tag "Track", then it rotates the aircraft towards the pathway.
8. Created UI Image of Intro to Control which will be enabled when scene starts.
9. FinalMsg will be enabled when the activity is over.

## Work for Tomorrow
1. Trim Voice Overs.
2. Edit Images:
    1. - [x] Taxiway Centerline.
    2. - [x] Taxiway Holding Position Marking.
    3. - [x] Taxiway Location and Direction Signs.
    4. - [x] Undershoot or Overshoot.
    5. - [ ] Taxiway Direction Sign.
