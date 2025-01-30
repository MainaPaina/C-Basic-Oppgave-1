namespace Basic_Oppgave_1;

class Program
{
    static double boxForTemperature;
    static void Main(string[] args)
    {
        while (true)
        {
            // print text, asking for temperature
            Console.Write("Please enter outside temperature (in °C): "); // 444

            // get input from user
            string? input = Console.ReadLine();

            // check if input is valid double
            if (double.TryParse(input, out boxForTemperature) == true)
            {

                // input is valid double, and conversion succeeded.

                // gjør det samme
                Console.WriteLine($"You entered {boxForTemperature}°C");
                // tradisjonell måte
                Console.WriteLine("You entered " + boxForTemperature.ToString() + "°C");

                if (boxForTemperature < -250)
                {
                    Console.WriteLine("Unbearable cold, not suitable for humans to live.");
                }
                else if (boxForTemperature < -30)
                {
                    Console.WriteLine("Too cold... Can't compute...");
                }
                else if (boxForTemperature < -5)
                {
                    Console.WriteLine("Freezing cold!");
                }
                else if (boxForTemperature < 10)
                {
                    Console.WriteLine("Cold");
                }
                else if (boxForTemperature < 19)
                {
                    Console.WriteLine("Mild");
                }
                else if (boxForTemperature < 30)
                {
                    Console.WriteLine("Nice and warm");
                }
                else if (boxForTemperature < 50)
                {
                    Console.WriteLine("Way to warm");
                }
                else if (boxForTemperature >= 50)
                {
                    Console.WriteLine("Cooked!");
                }

                switch (boxForTemperature)
                {
                    case double n when (n < -250):
                        Console.WriteLine("Unbearable cold, not suitable for humans to live.");
                        break;

                    case double n when (n < -30):
                        Console.WriteLine("Too cold... Can't compute...");
                        break;

                    case double n when (n < -5):
                        Console.WriteLine("Freezing cold!");
                        break;

                    case double n when (n < 10):
                        Console.WriteLine("Cold");
                        break;

                    case double n when (n < 19):
                        Console.WriteLine("Mild");
                        break;

                    case double n when (n < 30):
                        Console.WriteLine("Nice and warm");
                        break;

                    case double n when (n < 50):
                        Console.WriteLine("Way to warm");
                        break;

                    case double n when (n >= 50):
                        Console.WriteLine("Cooked");
                        break;
                }
            }
            else {
                Console.WriteLine("Input is not valid, please try again");
            }
        }
    }
}
