# Sweepstakes

UserStory- Dependancy Injection:
-I'm using dependancy injection in the marketing firm class. When a marketing
firm object is created it requires a parameter of ISweepstakesManager to be passed in.

-By using dependancy injection here, I can have two separate types (in the 
case of the current user requirements) of management systems (stack vs queue).

-If there were to be a change in requirements all one would have to do is 
add a new sweepstakes manager type and have it contracted with ISweepstakesManager.

-This use of dependancy injection would actually leave this portion of the application
follow the "O" in solid as well. 
