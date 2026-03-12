# Top-Down-Project

Create a top down character controller for 2D. Your player should be able to move up, down, left, and right, and should not be affected by gravity. Add at least 2 walls to your scene that the player will need to navigate around and cannot walk through. Additionally, when the player is walking in a direction, change their sprite to look in that direction. If the player presses multiple movement inputs at the same time, for example both up and right, have them look in either of the two directions.

For your submission, you will need to upload a link to a public GitHub repository. I will provide a starter repository for everyone to copy with the sprite and project settings, but you will be in charge of importing the sprite, creating scenes, and writing the code. This will be counted as a quiz grade.

## Creating a Copy

To get started, you will need to do the following:

1. Make sure that you are signed in to GitHub.
2. At the top of the page, click the button that says "Fork".
3. Click the green "Create fork" button.
4. Click the green "Code" button and copy the link.
5. Open file explorer to the Downloads folder.
6. Right click in the Downloads folder, and select "Open Git Bash Here".
7. In the terminal, run the following, with the link you copied from earlier instead of "link"

```bash
git clone link
```

8. After you clone your fork, run the following:

```bash
cd Top-Down-Project
```

9. Launch Unity Hub.
10. Click the "Add" button next to the blue "New Project" button.
11. Select "Add project from disk"
12. Go to your Downloads folder and select the new "Top-Down-Project" folder.
13. Launch the Unity project.

## Uploading your Changes

After you have made all of your changes and saved all of your files, you will need to do the following:

1. Launch Unity Hub.
2. Click the three dots next to "Top-Down-Project".
3. Select "Show in explorer".
4. Right click on the "Top-Down-Project" folder, and select "Open Git Bash Here".
5. In the terminal, run the following command to check what files were changed:

```bash
git status
```

6. In the terminal, run the following commands to create a version with your changes:

```bash
git add .
```

```bash
git commit -m "final submission"
```

7. In the terminal, run the following command to send your changes to the online GitHub repository:

```bash
git push origin master
```

8. Refresh the GitHub page, make sure your changes are there.
9. Copy the GitHub link and submit the link on Google Classroom.