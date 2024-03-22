using System;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        while (!endApp)
        {
            Console.WriteLine("\nWelcome to Your Personal Information System\n");

            string name = GetName();
            int age = GetAge();
            double height = GetHeight();

            Console.WriteLine("\n------------------------\nYour Personal Details:");
            Console.WriteLine($"Name: {name}\nAge: {age}\nHeight: {height} meters");

            CheckAge(age, name);
            CheckLegalDrinkingAge(age, name);

            Console.WriteLine("\nPersonal Details Presentation:");
            Console.WriteLine($"Your Personal Information: {name}, {age} years old, {height} meters tall");

            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("Thank you for using your Personal Information System!");
            Console.WriteLine("-----------------------------------------------------\n");

            Console.Write("Press 'n' then Enter to close the app, OR press any other key and Enter to continue: ");
            if (Console.ReadLine().ToLower() == "n") 
                endApp = true;

            Console.WriteLine();
        }
    }

    static string GetName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int GetAge()
    {
        int age;
        while (true)
        {
            Console.Write("Please enter your age: ");
            if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                break;
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
        }
        return age;
    }

    static double GetHeight()
    {
        double height;
        while (true)
        {
            Console.Write("Please enter your height in meters: ");
            if (double.TryParse(Console.ReadLine(), out height) && height >= 0)
                break;
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
        }
        return height;
    }

    static void CheckAge(int age, string name)
    {
        const int verifyAge = 18;
        Console.WriteLine("\nAge Check:");
        if (age >= verifyAge)
        {
            Console.WriteLine($"Welcome, {name}! You're eligible for additional features.");
        }
        else
        {
            Console.WriteLine("You are still a minor.");
        }
    }

    static void CheckLegalDrinkingAge(int age, string name)
    {
        const int LEGAL_DRINKING_AGE = 21;
        Console.WriteLine("\nLegal Drinking Age Verification:");
        if (age >= LEGAL_DRINKING_AGE)
        {
            Console.WriteLine($"Cheers, {name}! You're legally allowed to enjoy alcoholic beverages.");
        }
        else
        {
            Console.WriteLine("Sorry, you are underage for drinking.");
        }
    }
}
