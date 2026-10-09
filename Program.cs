namespace Dice;

class Program
{
    static readonly Random random = new();

static void Main()
    {

while (true)
    {
    Throw();

            Console.WriteLine("Vill du försöka igen?        skriv: J/N (Ja/Nej)");
            string choice = Console.ReadLine()!.ToLower();
                        
            if(choice == "n")
                {
                    Console.WriteLine("Avslutar spel");
                    break;
                }

            else if (choice != "j")
                {
                    Console.WriteLine("Fel tecken");
                    break;
                }         
        }
}

public static void Throw()
    {

    int randomnr1 = random.Next(1, 7);
    int randomnr2 = random.Next(1, 7);
    int Value = randomnr1 + randomnr2;
    int remaining = 12 - Value;

    Console.WriteLine("");
    Console.WriteLine("Första tärningen blev: "+ randomnr1);
    Console.WriteLine(" Andra tärningen blev: "+ randomnr2);
    Console.WriteLine("");
    Console.WriteLine("               totalt: "+ Value);

if(Value != 12)
    {
        Console.WriteLine($"            Du behövde {remaining} till för att vinna");
        Console.WriteLine("");
    }

else
        {
            Console.WriteLine("");
            Console.WriteLine("Wow, du vann!!!");
            Console.WriteLine("");
        }
    
    }
}