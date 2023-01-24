# Movie-Database
MOVIE DATABASE
Objectives: Lists of Objects and basic Database concepts

Task: List movies by category.

What will the application do?
The application stores a list of 10 movies and displays them by category.
The user can enter any of the following categories to display the films in the list that match the category: animated, drama, horror, scifi.
After the list is displayed, the user is asked if he or she wants to continue. If no, the program ends.

Build Specifications:
Build a Movie class with two member variables:  title and category. Both of these should be strings. The class should also provide a constructor that accepts a title and category as parameters and uses the values passed in to initialize the member variables.
Class has member variables of the correct type —2  points total
Class has constructor—1 point
In your program.cs file, create a List<Movie> and store at least 10 movies there. You can use literals to construct the movies. Make sure to have a mixture of categories.
Program constructs list properly—1 point
Program puts at least 10 properly instantiated Movies into the List—1 point
When the user enters a category, the program should read through all of the movies in the List and display a line for any movie whose category matches the category entered by the user.
Program takes user input correctly—1 point
Program gives explicit feedback if user enters invalid category—1 point
Program iterates through List validly—1 point
Program only outputs if movie matches category—1 point
Program loops if user wants to continue.
Program loops back to ask category again based on user input—1 point

Hints:
Don’t overthink this! Think about how you would do this in real life if you work at a video store, and you have a stack of movies and somebody wants to see which movies in that stack belong to a particular category. When one customer asks for a list of movies, how many times do you loop through the stack of movies?

Extra Challenges:
Standardize the category codes by displaying a menu of categories and having the user select the category by number rather than entering the name.
Display the movies for the selected category in alphabetical order.
Expand the information in your Movie class—run time in minutes, year released, etc. Display the additional information when listing movies.


Console Preview: 

Welcome to the Movie List Application!

There are 15 movies in this list. 
What category are you interested in? scifi
Star Wars
2001: A Space Odyssey
E.T. The Extra-terrestrial
A Clockwork Orange
Close Encounters of the Third Kind

Continue? (y/n): Y
What category are you interested in? …

