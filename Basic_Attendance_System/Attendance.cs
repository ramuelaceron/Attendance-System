using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Attendance_System
{
    internal class Attendance
    {
        static List<DateTime> userTime = new List<DateTime>();
        public static void TimeStorage(int menu)
        {
            Console.Write("Enter Arriving Time (HH:MM): ");
            DateTime time = DateTime.Parse(Console.ReadLine());

            while (true)
            {
                if (menu == 0)
                {
                    userTime.Add(time);
                    Console.WriteLine($"Data added successfully!");
                }
                else if (menu == 1)
                {
                    userTime.Add(time);
                    Console.WriteLine("Data added successfully!");
                }
                else if (menu == 2)
                {
                    userTime.Add(time);
                    Console.WriteLine("Data added successfully!");
                }
                string result = AttendanceFunction.StudentStatus(time, menu);
                Console.WriteLine("\t\t\t\t\t\tStatus: " + result);

                if (userTime.Count > 0)
                {
                    Console.WriteLine("\n\t\t\t\t\t\tCollected User Data:");

                    // Loop through the list and print each data point
                    foreach (DateTime data in userTime)
                    {
                        Console.WriteLine("\t\t\t\t\t\t" + data);
                    }
                }
                else
                {
                    Console.WriteLine("No user data collected.");
                }

                if (userTime.Count == 6)
                {
                    Console.Write("Press Enter to see Report, Input N/n if not: ");
                    string userchoice = Console.ReadLine();

                    if (userchoice == "N" || userchoice == "n")
                    {
                        Console.WriteLine("Thank you!");
                    }
                    else
                    {
                        Console.Clear();
                        Report.AttendanceReport(menu, time);
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public static DateTime Student1Math()
        {
            DateTime mathTime = userTime[0];
            return mathTime;
        }
        public static DateTime Student1Science()
        {
            DateTime scienceTime = userTime[1];
            return scienceTime;
        }
        public static DateTime Student1History()
        {
            DateTime historyTime = userTime[2];
            return historyTime;
        }
        public static DateTime Student2Math()
        {
            DateTime mathTime = userTime[3];
            return mathTime;
        }
        public static DateTime Stud2Science()
        {
            DateTime scienceTime = userTime[4];
            return scienceTime;
        }
        public static DateTime Student2History()
        {
            DateTime historyTime = userTime[5];
            return historyTime;
        }
    }
}
