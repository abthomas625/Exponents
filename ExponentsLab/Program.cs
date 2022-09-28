namespace ExponentsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            while (goOn == true)
            {

                Console.WriteLine("Welcome to the Number Exponent Analyzer! Please enter a number greater than 1.");
                int num = int.Parse(Console.ReadLine());
                bool pos = num > 0;

                if (pos && num >= 1)
                {
                    string s = String.Format("{0,6} {1,7} {2,5}", "Number", "Squared", "Cubed");
                    Console.WriteLine(s);
                    //Console.WriteLine("\nNumber  Squared  Cubed");

                    for (int i = 1; i <= num; i++)
                    {
                        s = String.Format("{0,6} {1,7} {2,5}", i, i * i, i * i * i);
                        Console.WriteLine(s);
                        //Console.WriteLine(i + "\t" + (i * i) + "\t " + (i * i * i));
                    }
                }
                else
                {
                    Console.WriteLine("Number invalid. Please input number between 1 and 100.");
                    return;
                }
                    goOn = AskToContinue();
                }
            }
            public static bool AskToContinue()
            {
                Console.WriteLine("Would you like to create another table? Y/N");
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid answer. Please try again.");
                    return AskToContinue();
                }
            }
        }
    }
