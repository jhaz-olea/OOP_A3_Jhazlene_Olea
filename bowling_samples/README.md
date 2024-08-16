### Problem Statement
Develop an API in C# to score a traditional bowling game. The API should handle the following:

1. Input the number of pins knocked down for each roll.
2. Calculate the score for each frame.
3. Handle strikes, spares, and open frames.
4. Provide the total score at the end of the game.

### Rules and Mechanics
1. Game Structure: A game consists of 10 frames.
2. Rolls per Frame: Each frame allows up to 2 rolls, except the 10th frame, which can have up to 3 rolls if a strike or spare is scored.
3. Scoring:
 - Strike: Knocking down all 10 pins on the first roll. Score = 10 + the number of pins knocked down in the next two rolls.
- Spare: Knocking down all 10 pins in two rolls. Score = 10 + the number of pins knocked down in the next roll.
- Open Frame: Fewer than 10 pins knocked down in two rolls. Score = total number of pins knocked down in that frame.
4. Maximum Score: The maximum score is 300, achieved by rolling 12 strikes in a row.