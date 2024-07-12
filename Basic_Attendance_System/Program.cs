using System.Security.Principal;

namespace Basic_Attendance_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(".________________________________________________________________.");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("| ***************** STUDENT ATTENDANCE SYSTEM ****************** |");
                Console.WriteLine("| SCHEDULE                                                       |");
                Console.WriteLine("| Math                           :   8:00AM – 10:00AM            |");
                Console.WriteLine("| Science                        :  10:30AM – 12:30PM            |");
                Console.WriteLine("| History                        :  14:00PM – 16:00PM            |");
                Console.WriteLine("|________________________________________________________________|");

                Console.Write("\nEnter your student number: ");
                string userinput = Console.ReadLine();

                if (Account.Login(userinput))
                {
                    Menu.Show(userinput);
                    Console.Write("Press Enter to continue...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
        }
    }
}
