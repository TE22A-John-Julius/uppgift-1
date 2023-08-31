// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, what's your name?");

string name = Console.ReadLine();

Console.WriteLine($"Hey {name} could you give me your favorite game?");

string game = Console.ReadLine();

Console.WriteLine($"OML i aint gon lie {game} is pretty good, W opinion! Could you tell me how many hours you have on that game?");

string hours = Console.ReadLine();

Console.WriteLine($"DANNGGGG {hours} hours not too shabby. So what you're telling me {name} is that you're favorite game is {game} and you've spent {hours} hours on it?");

string answer = Console.ReadLine();

if (answer == "yes")
    {
        Console.WriteLine($"Alright {name} I hope you have a good day!");
    }

else {
    Console.WriteLine($"{name} please rerun the program!");
}
Console.ReadLine();