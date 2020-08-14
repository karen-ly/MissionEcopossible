# Mission Ecopossible
## Introduction

This app was created by ECOders, a team consisting of Anisha Kabir, Fan Wang, Karen Ly, and Zhuofan Li, who participated in Dandilyonn’s 2020 SEEDs program. Mission Ecopossible is an interactive mobile game that seeks to educate users about ocean pollution and the proper disposal of waste.

Technical Coach: Ravin Jain 

Graphics designed by: Fan Wang

<img src="DemoImages/characters.png" width="300" height="270">

### Technologies Used: 
Built with C#, Unity

## Demonstration
### Loading Scene

### Dialogue Scene
For each level of chapter 1, the player interacts with the main characters (Dede, Bebe, and Cece) and learn more about their unique stories.

<img src='http://g.recordit.co/LFFty51jTW.gif' title='Dialogue Sample' width='' alt='Dialogue Sample' />

### Submarine Game

### Sorting Game 
After the player collects all the garbages at Level 2, 3 and 4, the player sorts all of them at Level 5. By dragging garbage item into the corresponding trash bin, the player can enhance the sorting knowledge we learnt in the submarine game at Level 2, 3 and 4. A reminder will pop up if the garbage item is not placed in the correct trash bin.

<img src='DemoImages/sortingGame.gif' title='Sorting Game' width='' alt='Sorting Game' />

## Installation

Coming soon!

### App Store

### From GitHub

## Building

### With xCode

This project requires the [Android SDK](http://developer.android.com/sdk/index.html)
to be installed in your development environment. In addition you'll need to set
the `ANDROID_HOME` environment variable to the location of your SDK. For example:

    export ANDROID_HOME=/home/<user>/tools/android-sdk

After satisfying those requirements, the build is pretty simple:

* Run `./gradlew build installDevelopmentDebug` from the within the project folder.
It will build the project for you and install it to the connected Android device or running emulator.

The app is configured to allow you to install a development and production version in parallel on your device.

### With Android Studio
The easiest way to build is to install [Android Studio](https://developer.android.com/sdk/index.html) v2.+
with [Gradle](https://www.gradle.org/) v3.4.1
Once installed, then you can import the project into Android Studio:

1. Open `File`
2. Import Project
3. Select `build.gradle` under the project directory
4. Click `OK`

Then, Gradle will do everything for you.

## Features In Progress
- Tracking player's progress through different chapters and levels
- Create a better badges panel that updates everytime the user completes a chapter
- Implement a working restart button in settings page to delete all of user's progress
- Lock uncompleted levels
