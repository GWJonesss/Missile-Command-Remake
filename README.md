# Missile Command Remake 1.0

For My First Live Project While Attending The Tech Academy I Created A Missile Command Remake.

## Missile Command Scenes and Game Objects
First part of the project was creating the screens for Missile Command. Each were made within Unity, and movement between them was controlled by using buttons that had an attached script to load the correct scene. Along with the base scenes, Building Game Objects were created to be later used in the scoring system.

*What Moving Between Scenes Looks Like:*<br />
![](https://github.com/GWJonesss/Missile-Command-Remake/blob/main/README-ASSETS/SceneSwap.gif)



## Player Aim, Shoot, Reload, and Menu Functionality 
Player Aim And Shoot Functionality is controlled through the Mouse axis and Left Button inputs. Scripts are included to prevent the player being able to shoot once their allotted ammo amount. If a player's score exceeds 100, the player is presented with a message and functionality to press the 'R' key to buy 10 extra ammo at the cost of 100 points being subtracted from their overall score. While in the 'Game' scene, at any point, the player has the option to press the 'M' key to pause the game and have the option to quit, go back to the starting menu, or adjust the volume of the music and effects.

*Pulling Up The Menu In Game Looks Like This:*<br />
![](https://github.com/GWJonesss/Missile-Command-Remake/blob/main/README-ASSETS/MenuUse.gif)


## Enemy Missile Movement and Spawning
A script attached to an "Enemy Spawner" game object instantiates Enemy Missiles slightly off screen. Upon awake the Enemy Missiles have an attached script that directs them to generate a random number that correlates to a target that they will start moving towards at a steady rate.

Once The Player reaches level 2 the script introduces a new option for the enemy missile to destroy itself and spawn 4 smaller missiles that all follow 
the random number target selection the larger enemy missile had.

*That Occurrence Looks Like This:*<br />
![](https://github.com/GWJonesss/Missile-Command-Remake/blob/main/README-ASSETS/MissileSplit.gif)

At Level 3 The Larger Missiles increase their movement speed on top of all of the previous adjustments. 


## Score

The Players Score is handled by a piece of script in the Enemy.cs file that is connected to a variable from a game controller script through a function. 

*Seen Here:*<br />
![](https://github.com/GWJonesss/Missile-Command-Remake/blob/main/README-ASSETS/ScoreScript.png)


The score text at the top updates based on every use of the AddMissileDestDestroyedScore() function.
The Building game objects, if hit by an enemy missile, will be destroyed and will update the 
Buildings Destroyed Text with a similar piece of code connecting all of the involved game objects and text.


## Win/Lose win condition
To get a basic win condition a player must make it past level 3(300 total enemy missiles destroyed) with at least 1 building intact. 
Although doing so triggers a 'Win', the true goal is to achieve the highest total score possible by strategic use of ammo purchasing and picking the right time to shoot down an enemy missile so that it causes a chain reaction so your ammo expenditure will have the most impact posible.

A Loose condition is met if all 6 buildings are destroyed by enemy missile collisions before a player is able to achieve a win condition.

Both conditions send you to a Game Over Screen and alow you to view your total Score.

*Example "Game Over" screen:*<br />
![](https://github.com/GWJonesss/Missile-Command-Remake/blob/main/README-ASSETS/GameOver.gif)
