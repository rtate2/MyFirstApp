using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Press your name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);
            Console.ReadLine();

            if (userEntry == "Randy")
            {
                Console.WriteLine("You are awesome");
            }
            else
            {
                Console.WriteLine("You are awesome, but not as much");
            }

            var j = 0;
            while (j < 10)
            {
                Console.WriteLine($"Current value of i is {j++}...");
            }

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current value of i is {i}...");
            }

            foreach (var currentCharacter in userEntry)
            {
                if (currentCharacter == 'n' || currentCharacter == 'N')
                {
                    continue;
                }
                Console.WriteLine($"The current character is {currentCharacter}.");
            }

            switch (userEntry)
            {
                case "Randy":
                    Console.WriteLine("It's Randy");
                    break;
                default:
                    Console.WriteLine("Its anything but Randy");
                    break;
            }

            var isRandy = userEntry == "Randy" ? true : false;

            try
            {
                var y = 0;
                var z = 1;
                var x = 1 / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
