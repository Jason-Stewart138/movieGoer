using movieGoer;

Console.WriteLine("Please enter your name");
string userName = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Please enter your age");
int userAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Please Select A Movie Genre By Entering The Cooresponding Number");
Console.WriteLine($"1. {MovieGenre.Fantasy}");
Console.WriteLine($"2. {MovieGenre.Horror}");
Console.WriteLine($"3. {MovieGenre.Romance}");
Console.WriteLine($"4. {MovieGenre.Action}");
Console.WriteLine($"5. {MovieGenre.Documentary}");
Console.WriteLine($"6. {MovieGenre.Thriller}");
Console.WriteLine($"7. {MovieGenre.Drama}");
Console.WriteLine($"8. {MovieGenre.Comedy}");
Console.WriteLine($"9. {MovieGenre.Family}");
Console.WriteLine($"10. {MovieGenre.Western}");
Console.WriteLine();

int movieGenreSelecion = Convert.ToInt32(Console.ReadLine());

MovieGenre movieGenre = (MovieGenre)movieGenreSelecion;


Console.WriteLine("Please Select A Movie Rating By Entering The Cooresponding Number");
Console.WriteLine($"1. {MovieRating.G}");
Console.WriteLine($"2. {MovieRating.PG}");
Console.WriteLine($"3. {MovieRating.PG13}");
Console.WriteLine($"4. {MovieRating.R}");
Console.WriteLine($"5. {MovieRating.NC17}");
Console.WriteLine();

int movieRatingSelecion = Convert.ToInt32(Console.ReadLine());

MovieRating movieRating = (MovieRating) movieRatingSelecion;

switch (movieGenre)
{
    case MovieGenre.Fantasy:
        switch (movieRating)
        {
            case MovieRating.G:
                 Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                 Console.WriteLine("The Visitors II: The Corridors of Time");
                 Console.WriteLine("Charlotte's Web");
                 Console.WriteLine("Inspector Gadget 2");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Hugo");
                Console.WriteLine("Hocus Pocus");
                Console.WriteLine("Ernest Scared Stupid");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Indiana Jones and the Last Crusade");
                    Console.WriteLine("Iron Man");
                    Console.WriteLine("The Mask");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.R:
                if(userAge >= 17)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("300");
                    Console.WriteLine("Blade");
                    Console.WriteLine("Hollow Man");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");
                    
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                Console.WriteLine("You Made An Invalid Selection, Goodbye");
                Environment.Exit(0);
                break;
        }
        break;
    case MovieGenre.Horror:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");
                
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Hugo");
                Console.WriteLine("Hocus Pocus");
                Console.WriteLine("Ernest Scared Stupid");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Indiana Jones and the Last Crusade");
                    Console.WriteLine("Iron Man");
                    Console.WriteLine("The Mask");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.R:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Bodies Bodies Bodies");
                    Console.WriteLine("Dahmer");
                    Console.WriteLine("American Psycho");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");
                    
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                Console.WriteLine("You Made An Invalid Selection, Goodbye");
                Environment.Exit(0);
                break;
        }
        break;
    case MovieGenre.Romance:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("The Visitors II: The Corridors of Time");
                Console.WriteLine("Charlotte's Web");
                Console.WriteLine("Inspector Gadget 2");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Hugo");
                Console.WriteLine("Hocus Pocus");
                Console.WriteLine("Ernest Scared Stupid");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Indiana Jones and the Last Crusade");
                    Console.WriteLine("Iron Man");
                    Console.WriteLine("The Mask");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.R:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("300");
                    Console.WriteLine("Blade");
                    Console.WriteLine("Hollow Man");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");
                    
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                Console.WriteLine("You Made An Invalid Selection, Goodbye");
                Environment.Exit(0);
                break;
        }
        break;
    case MovieGenre.Action:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("The Visitors II: The Corridors of Time");
                Console.WriteLine("Charlotte's Web");
                Console.WriteLine("Inspector Gadget 2");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Hugo");
                Console.WriteLine("Hocus Pocus");
                Console.WriteLine("Ernest Scared Stupid");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Indiana Jones and the Last Crusade");
                    Console.WriteLine("Iron Man");
                    Console.WriteLine("The Mask");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.R:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("300");
                    Console.WriteLine("Blade");
                    Console.WriteLine("Hollow Man");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");
                   
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                Console.WriteLine("You Made An Invalid Selection, Goodbye");
                Environment.Exit(0);
                break;
        }
        break;
    case MovieGenre.Documentary:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("The Visitors II: The Corridors of Time");
                Console.WriteLine("Charlotte's Web");
                Console.WriteLine("Inspector Gadget 2");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Hugo");
                Console.WriteLine("Hocus Pocus");
                Console.WriteLine("Ernest Scared Stupid");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Indiana Jones and the Last Crusade");
                    Console.WriteLine("Iron Man");
                    Console.WriteLine("The Mask");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.R:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("300");
                    Console.WriteLine("Blade");
                    Console.WriteLine("Hollow Man");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");
                    
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                Console.WriteLine("You Made An Invalid Selection, Goodbye");
                Environment.Exit(0);
                break;
        }
        break;
    case MovieGenre.Thriller:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("The Visitors II: The Corridors of Time");
                Console.WriteLine("Charlotte's Web");
                Console.WriteLine("Inspector Gadget 2");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Hugo");
                Console.WriteLine("Hocus Pocus");
                Console.WriteLine("Ernest Scared Stupid");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Indiana Jones and the Last Crusade");
                    Console.WriteLine("Iron Man");
                    Console.WriteLine("The Mask");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.R:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");
                  
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("300");
                    Console.WriteLine("Blade");
                    Console.WriteLine("Hollow Man");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                Console.WriteLine("You Made An Invalid Selection, Goodbye");
                Environment.Exit(0);
                break;
        }
        break;
    case MovieGenre.Drama:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("The Visitors II: The Corridors of Time");
                Console.WriteLine("Charlotte's Web");
                Console.WriteLine("Inspector Gadget 2");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Hugo");
                Console.WriteLine("Hocus Pocus");
                Console.WriteLine("Ernest Scared Stupid");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Indiana Jones and the Last Crusade");
                    Console.WriteLine("Iron Man");
                    Console.WriteLine("The Mask");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.R:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("300");
                    Console.WriteLine("Blade");
                    Console.WriteLine("Hollow Man");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");
                  
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                Console.WriteLine("You Made An Invalid Selection, Goodbye");
                Environment.Exit(0);
                break;
        }
        break;
    case MovieGenre.Comedy:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("The Visitors II: The Corridors of Time");
                Console.WriteLine("Charlotte's Web");
                Console.WriteLine("Inspector Gadget 2");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Hugo");
                Console.WriteLine("Hocus Pocus");
                Console.WriteLine("Ernest Scared Stupid");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Indiana Jones and the Last Crusade");
                    Console.WriteLine("Iron Man");
                    Console.WriteLine("The Mask");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.R:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("300");
                    Console.WriteLine("Blade");
                    Console.WriteLine("Hollow Man");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");
  
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                Console.WriteLine("You Made An Invalid Selection, Goodbye");
                Environment.Exit(0);
                break;
        }
        break;
    case MovieGenre.Family:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("The Visitors II: The Corridors of Time");
                Console.WriteLine("Charlotte's Web");
                Console.WriteLine("Inspector Gadget 2");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Hugo");
                Console.WriteLine("Hocus Pocus");
                Console.WriteLine("Ernest Scared Stupid");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Indiana Jones and the Last Crusade");
                    Console.WriteLine("Iron Man");
                    Console.WriteLine("The Mask");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.R:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("300");
                    Console.WriteLine("Blade");
                    Console.WriteLine("Hollow Man");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");

                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                Console.WriteLine("You Made An Invalid Selection, Goodbye");
                Environment.Exit(0);
                break;
        }
        break;
    case MovieGenre.Western:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("The Visitors II: The Corridors of Time");
                Console.WriteLine("Charlotte's Web");
                Console.WriteLine("Inspector Gadget 2");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Hugo");
                Console.WriteLine("Hocus Pocus");
                Console.WriteLine("Ernest Scared Stupid");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Indiana Jones and the Last Crusade");
                    Console.WriteLine("Iron Man");
                    Console.WriteLine("The Mask");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.R:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("300");
                    Console.WriteLine("Blade");
                    Console.WriteLine("Hollow Man");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                Console.WriteLine("You Made An Invalid Selection, Goodbye");
                Environment.Exit(0);
                break;
        }
        break;
    default:
        Console.WriteLine("You Made An Invalid Selection, Goodbye");
        Environment.Exit(0);
        break;
}

