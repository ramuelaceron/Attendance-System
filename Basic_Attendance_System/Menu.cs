using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Attendance_System
{
    internal class Menu
    {
        static List<string> Subject = new List<string>();
        private static void UsersSubjects()
        {
            Subject.Add("Math");
            Subject.Add("Science");
            Subject.Add("History");
        }
        public static void Show(string user)
        {
            UsersSubjects();

            Console.WriteLine("Select actions below");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"  Enter {i} to select {Subject[i]} for attendance");
            }
            for (int i = 0; i < 3; i++)
            {
                int selectedMenu = InputMenu();
                Attendance.TimeStorage(selectedMenu);
            }
        }
        public static int InputMenu()
        {
            Console.Write("\nInput menu to select: ");
            int selectedMenu = Convert.ToInt32(Console.ReadLine());

            return selectedMenu;
        }
    }
}
