using System;

namespace ConsoleApp9
{
    class Program
    {

        static void Main()
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number(or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree(); // Call your next assignment method here!
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number");
                    Console.ResetColor();

                }
            }
        }




        private static void RunExerciseOne()
        {
            Console.WriteLine("Hello Qassem Aburas");
        }
        private static void RunExerciseTwo()
        {
            DateTime todaysDateIs = DateTime.Today;
            Console.WriteLine(todaysDateIs);
            DateTime tomorrowaDateIs = DateTime.Today.AddDays(+1);
            Console.WriteLine(tomorrowaDateIs);
            DateTime yesterdayDateIs = DateTime.Today.AddDays(-1);
            Console.WriteLine(yesterdayDateIs);

        }
        private static void RunExerciseThree()
        {
            Console.ResetColor();
            Console.Write("Enter your first name: ");
            String firstName = Console.ReadLine();
            //Console.ReadKey();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("The fullname: " + firstName + " " + lastName);
            Console.ReadKey();
            Console.Clear();
        }
        private static void RunExerciseFour()
        {
            string str = "The quick fox Jumped Over the DOG"; // The brown fox jumped over the lazy dog
                                                              //cod

            string modefied1 = "";
            modefied1 = str.Insert(30, "lazy ");
            Console.WriteLine(modefied1);
        

            string modefied2 = "";
            modefied2 = str.Replace("quick", "brown");
            Console.WriteLine(modefied2);
        

            string modefied3 = "t";
            modefied3 = str.Remove(0);
            Console.WriteLine(modefied3);

            string modefied4 = "";
            modefied4 = str.ToLower();
            Console.WriteLine(modefied4);

            string modefied5 = "";
            modefied5 = str.Replace("the", "The");
            Console.WriteLine(modefied5);




        }// end of Main
    }// end of class
}// end of namespace
