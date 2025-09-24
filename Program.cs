using System;

class Program
{
    
    static void Main(string[] args)
    {
        // ----- Meny och val -----
        Console.WriteLine("Välj en operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");
        
        // Använder en separat metod för att läsa in ett giltigt menyval (1-4).
        int choice = GetMenuChoice();

        int num1 = GetIntegerFromUser("Ange det första talet: ");
        int num2 = GetIntegerFromUser("Ange det andra talet: ");

      
        switch (choice)
        {
            case 1:
                int sum = Add(num1, num2);
                Console.WriteLine($"Resultat: {num1} + {num2} = {sum}");
                break;
            case 2:
                int difference = Subtract(num1, num2);
                Console.WriteLine($"Resultat: {num1} - {num2} = {difference}");
                break;
            case 3:
                int product = Multiply(num1, num2);
                Console.WriteLine($"Resultat: {num1} * {num2} = {product}");
                break;
            case 4:
             
                if (num2 == 0)
                {
                    Console.WriteLine("Fel: Det går inte att dividera med noll.");
                }
                else
                {
                    double quotient = Divide(num1, num2);
                    Console.WriteLine($"Resultat: {num1} / {num2} = {quotient}");
                }
                break;
     
            default:
                Console.WriteLine("Ett oväntat fel inträffade med menyvalet.");
                break;
        }
    }

 

    static int GetMenuChoice()
    {
        int choice;
        while (true)
        {
            Console.Write("Ange ditt val (1-4): ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
            {
                return choice; // Giltigt val, returnera det.
            }
            Console.WriteLine("Ogiltigt val. Vänligen ange en siffra mellan 1 och 4.");
        }
    }

    static int GetIntegerFromUser(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number; // Giltigt heltal, returnera det.
            }
            Console.WriteLine("Ogiltig inmatning. Vänligen ange ett heltal.");
        }
    }
    

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static double Divide(int a, int b)
    {
        // Konverterar 'a' till double INNAN divisionen för att undvika heltalsdivision.
        return (double)a / b;
    }
}
