using Movie_Database;
using System.Diagnostics.Metrics;

//What will the application do?
//The application stores a list of 10 movies and displays them by category.
//The user can enter any of the following categories to display the films in the list that match the category
//: animated, drama, horror, scifi.
//After the list is displayed, the user is asked if he or she wants to continue. If no, the program ends.

//Build Specifications:
//Build a Movie class with two member variables:  title and category. Both of these should be strings.
//The class should also provide a constructor that accepts a title and category as parameters and uses the values
//passed in to initialize the member variables.
//Class has member variables of the correct type —2  points total
//Class has constructor—1 point
//In your program.cs file, create a List<Movie> and store at least 10 movies there. You can use literals to construct
//the movies. Make sure to have a mixture of categories.
//Program constructs list properly—1 point
//Program puts at least 10 properly instantiated Movies into the List—1 point
//When the user enters a category, the program should read through all of the movies in the List and display a line
//for any movie whose category matches the category entered by the user.
//Program takes user input correctly—1 point
//Program gives explicit feedback if user enters invalid category—1 point
//Program iterates through List validly—1 point
//Program only outputs if movie matches category—1 point
//Program loops if user wants to continue.
//Program loops back to ask category again based on user input—1 point



List<Movie> movies = new List<Movie>()
{
    new Movie ("The Matrix", "scifi", " 2001", " 90 minutes"),
    new Movie ("The Lion King", "animated", " 2005", " 120 minutes"),
    new Movie ("Stepbrothers", "drama", " 2012", " 150 minutes"),
    new Movie ("Memento", "scifi", " 1995", " 120 minutes"),
    new Movie ("1984", "scifi", " 1987", " 90 minutes"),
    new Movie ("John Wick", "drama", " 2015", " 120 minutes"),
    new Movie ("Toy Story", "animated", " 2001", " 150 minutes"),
    new Movie ("Saw", "horror", " 2000", "120 minutes"),
    new Movie ("The Notebook", "horror", " 1997", " 90 minutes"),
    new Movie ("The Adventures of GC", "animated", "2023", " 120 minutes"),
    new Movie ("Back to the Future", "scfi ", " 1985", " 150 minutes"),
    new Movie ("The Office, The Movie", "drama", " 2024", " 120 minutes")
};

Console.WriteLine("Welcome to Move List Application!");

Console.WriteLine("There are 12 movies in this list.");

while(true)
{
    Console.WriteLine("What category are you interested in? ");
    string input = Console.ReadLine().ToLower().Trim();

    bool found = false;
    foreach (Movie m in movies)
    {
        if (m.Category == input)
        {
            Console.WriteLine(m.Title + m.Year + m.Runtime);
            found = true;
        }      
    }

    if(!found)
    {
        Console.WriteLine("Invalid category. Try again");
        found = true;

    }

    Console.WriteLine("Continue? y/n");
    string continueInput = Console.ReadLine().ToLower().Trim();
    if (continueInput != "y")
    {
        Console.WriteLine("Goodbye");
        break;       
    }
}