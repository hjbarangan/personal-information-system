

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to your Personal Information System!");

        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Please enter your age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your height in meters:");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("----------------");
        Console.WriteLine("Your Personal Details:");

        Console.WriteLine("Name: {0}", name);

        Console.WriteLine("Age: {0}", age);

        Console.WriteLine("Height: {0} meters", height);

        int LEGAL_DRINKING_AGE = 21;

        if (age >= 18)
        {
            Console.WriteLine("You are legally allowed to vote.");
        }
        else
        {
            Console.WriteLine("You are not legally allowed to vote.");
        }


        if (age >= LEGAL_DRINKING_AGE)
        {
            Console.WriteLine("You are legally allowed to drink alcohol.");
        }
        else
        {
            Console.WriteLine("You are not legally allowed to drink alcohol.");
        }
    }
}

