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

void NoSelections(string userName)
{
    Console.WriteLine($"Sorry {userName}, I Couldn't Find Anything That Met That Criteria");
}

void InvalidSelections()
{
    Console.WriteLine("You Made An Invalid Selection, Goodbye");
    Environment.Exit(0);
}

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
                    NoSelections(userName);
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                InvalidSelections();
                break;
        }
        break;
    case MovieGenre.Horror:
        switch (movieRating)
        {
            case MovieRating.G:
                NoSelections(userName);
                break;
            case MovieRating.PG:
                NoSelections(userName);
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("The Mortal Instruments: City of Bones");
                    Console.WriteLine("Split");
                    Console.WriteLine("Glass");
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
                    NoSelections(userName);
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                InvalidSelections();
                break;
        }
        break;
    case MovieGenre.Romance:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("The Little Mermaid");
                Console.WriteLine("Hercules");
                Console.WriteLine("Beauty and the Beast");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("The Princess Bride");
                Console.WriteLine("Little Women");
                Console.WriteLine("Grease");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Thor: Love and Thunder");
                    Console.WriteLine("Ticket to Paradise");
                    Console.WriteLine("Titanic");
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
                    Console.WriteLine("Fifty Shades of Grey");
                    Console.WriteLine("Good Will Hunting");
                    Console.WriteLine("Eternal Sunshine of the Spotless Mind");
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
                    Console.WriteLine("Blonde");
                    Console.WriteLine("Blue Is the Warmest Colour");
                    Console.WriteLine("The Dreamers");

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
                NoSelections(userName);
                break;
            case MovieRating.PG:
                NoSelections(userName);
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Avatar");
                    Console.WriteLine("The Avengers");
                    Console.WriteLine("Guardians of the Galaxy");
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
                    Console.WriteLine("Mad Max: Fury Road");
                    Console.WriteLine("Logan");
                    Console.WriteLine("Dead Pool");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    NoSelections(userName);
                   
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                InvalidSelections();
                break;
        }
        break;
    case MovieGenre.Documentary:
        switch (movieRating)
        {
            case MovieRating.G:
                NoSelections(userName);
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("The Rescue");
                Console.WriteLine("Flight/Risk");
                Console.WriteLine("Cosmos: A Spacetime Odyssey");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Superspreader");
                    Console.WriteLine("The Beatles: Get Back");
                    Console.WriteLine("The Alpinist");
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
                    Console.WriteLine("They Shall Not Grow Old");
                    Console.WriteLine("Jackass: The Movie (Yes IMDB listed this as a documentary)");
                    Console.WriteLine("Grizzly Man");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    NoSelections(userName);

                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                InvalidSelections();
                break;
        }
        break;
    case MovieGenre.Thriller:
        switch (movieRating)
        {
            case MovieRating.G:
                NoSelections(userName);
                break;
            case MovieRating.PG:
                NoSelections(userName);
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Fall");
                    Console.WriteLine("The Invitation");
                    Console.WriteLine("The Mother");
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
                    Console.WriteLine("Don't Worry Darling");
                    Console.WriteLine("Bullet Train");
                    Console.WriteLine("The Infernal Machine");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    NoSelections(userName);
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                InvalidSelections();
                break;
        }
        break;
    case MovieGenre.Drama:
        switch (movieRating)
        {
            case MovieRating.G:
                NoSelections(userName);
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Diary of a Wimpy Kid");
                Console.WriteLine("The Karate Kid");
                Console.WriteLine("Mrs. Harris Goes to Paris");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Top Gun: Maverick");
                    Console.WriteLine("The Batman");
                    Console.WriteLine("The Lord of the Rings: The Fellowship of the Ring");
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
                    Console.WriteLine("After Ever Happy");
                    Console.WriteLine("Pulp Fiction");
                    Console.WriteLine("The Enforcer");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    NoSelections(userName);
                  
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                InvalidSelections();
                break;
        }
        break;
    case MovieGenre.Comedy:
        switch (movieRating)
        {
            case MovieRating.G:
                NoSelections(userName);
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Airplane!");
                Console.WriteLine("Beetlejuice");
                Console.WriteLine("Nacho Libre");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Dumb and Dumber");
                    Console.WriteLine("Liar Liar");
                    Console.WriteLine("The Naked Gun: From the Files of Police Squad!");
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
                    Console.WriteLine("The Big Lebowski");
                    Console.WriteLine("Step Brothers");
                    Console.WriteLine("Clerks");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    NoSelections(userName);
  
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                InvalidSelections();
                break;
        }
        break;
    case MovieGenre.Family:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("Luck");
                Console.WriteLine("The Lion King");
                Console.WriteLine("Cars");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("DC League of Super-Pets");
                Console.WriteLine("Harry Potter and the Sorcerer's Stone");
                Console.WriteLine("Lightyear");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Fantastic Beasts: The Secrets of Dumbledore");
                    Console.WriteLine("Harry Potter and the Goblet of Fire");
                    Console.WriteLine("Harry Potter and the Order of the Phoenix");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.R:
                if (userAge >= 17)
                {
                    NoSelections(userName);
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    NoSelections(userName);

                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                InvalidSelections();
                break;
        }
        break;
    case MovieGenre.Western:
        switch (movieRating)
        {
            case MovieRating.G:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("How the West Was Won");
                Console.WriteLine("Support Your Local Sheriff!");
                break;
            case MovieRating.PG:
                Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                Console.WriteLine("High Noon");
                Console.WriteLine("Butch Cassidy and the Sundance Kid");
                Console.WriteLine("Hondo");
                break;
            case MovieRating.PG13:
                if (userAge >= 13)
                {
                    Console.WriteLine($"Here {userName}, I Can Suggest The Following Movies:");
                    Console.WriteLine("Once Upon a Time in the West");
                    Console.WriteLine("Paint Your Wagon");
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
                    Console.WriteLine("Unforgiven");
                    Console.WriteLine("The Wild Bunch");
                    Console.WriteLine("The Good, the Bad and the Ugly");
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            case MovieRating.NC17:
                if (userAge >= 17)
                {
                    NoSelections(userName);
                }
                else
                {
                    Console.WriteLine($"You're Not Old Enough To Watch A Rated {movieRating} Movie, I'm Telling!");
                }
                break;
            default:
                InvalidSelections();
                break;
        }
        break;
    default:
        InvalidSelections();
        break;
}

