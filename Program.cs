using System;


    class Program
    {
        static void Main()
        {
        bool? areyoumajor = null;
        string FirstName;
        string LastName;
        string answer;
        Console.WriteLine("What is your first name?");
        FirstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        LastName = Console.ReadLine();
        Console.WriteLine("Are you major? Yes or No.");
        answer = Console.ReadLine();
        Console.WriteLine(FirstName + "\n" + LastName + "\n");

        if (answer == "Yes")
        {
            areyoumajor = true;
        }

        if (answer == "No")
        {
            areyoumajor = false;
        }

        if (areyoumajor == true)
        {
            Console.WriteLine("you are major.");
        }

        else if(areyoumajor == false)
        {
            Console.WriteLine("You're not major.");
        }
        else
        {
            Console.WriteLine("There was no answer.");
        }

    }
    }
