using System.Runtime.CompilerServices;

namespace OldStyleApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name1 = "Ali";

            /* foreach EXAMPLE
             * string[] cars = { "Volvo", "BMW", "Ford" };
            foreach (string car in cars) {
                Console.WriteLine(car);
            }
            */


            /* (GIVEN BELOW IS THE EXPRESSION TO USE SwitchCaseExample)
               (Please delete this line, the above line in the bracates and multiline comment symbol)
            Console.WriteLine("Please enter the name of the day");
            string dayName = Console.ReadLine();Main.cs

 Run 

            SwitchCaseExample(dayName);
 
            */
            BreakAndContinue(0);
        }

        public static void BreakAndContinue(int i)
        {

            while (i < 1000)
            {
                i++;
                if ((i % 10) == 0 && (i%3==0) && i % 5 == 0 && i%9==0)
                {
                    break;
                }
                else if (i % 3 == 0)
                {
                    continue;
                }
                else if (i % 5 == 0)
                {
                    continue;
                }
                
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void SwitchCaseExample(string day)
        {
            day = day.ToLower();
            switch (day)
            {
                case "monday":
                    Console.WriteLine("This is 1st day of the week");
                    break;
               case "tuesday":
                    Console.WriteLine("This is 2nd day of the week");
                    break;
               case "wednesday":
                    Console.WriteLine("This is 3rd day of the week");
                    break;
               case "thursday":
                    Console.WriteLine("This is 4th day of the week");
                    break;
               case "friday":
                    Console.WriteLine("This is 5th day of the week");
                    break;
               case "satday":
                    Console.WriteLine("This is 6th day of the week");
                    break;
               case "sunday":
                    Console.WriteLine("This is 7th day of the week");
                    break;
               default:
                    Console.WriteLine("Please enter the valid day");
                    break;

            }
        }

        //this method promts a greeting message
        public static void Greet(string name)
        {
            Console.WriteLine("Hello " +name+ ", How are you?");

        }

        //this method converts strings in lower and upper case
        public static void LowUpper(string word)
        {
            Console.WriteLine(word.ToUpper());
            Console.WriteLine(word.ToLower());
            Console.WriteLine("This word has " + word.Length + " letters");
        }

        //this method gives sum of two number
        public static int Sum(int num1, int num2)
        {
            return (num1 + num2);
        }

        //
    }
}
