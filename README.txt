The grate Bowling game is here!!!

for running the game please run exe file at
 "..\..\BowlingGameProject\BowlingGameProject\bin\Debug\BowlingGameProject.exe"
 
if u run the game without providing any args, the game will run with defualt configuration:
- Frame Number = "10"
- Pins Number = "10"
- Spare Extra Throws = "1" 
- Strike Extra Throws = "2"

for start the game with ather configuration - provid 4 positive number as args 
-> run in the command-line at the above location BowlingGameProject.exe <arg1> <arg2> <arg3> <arg4>
		- Frame Number = <arg1>
		- Pins Number = <arg2>
		- Spare Extra Throws = <arg3> 
		- Strike Extra Throws = <arg4>
		
Game flow:
-----------------------------------------------------------------
-> loop on frames number
     -> check if the frame is still active
     -> get from user how many pins dropped
     -> validate number
     -> play
     -> updating score for previous frames with specific states
     -> print status
-> loop until there isn't frame to update
     -> updating scores
     -> print status
-----------------------------------------------------------------