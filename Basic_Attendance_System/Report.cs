using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Attendance_System
{
    internal class Report
    {
        static List<string> StudentStatus = new List<string>();
        public static void AttendanceReport(int menu, DateTime time)
        {
            StudentStatus.Add(ReportFunction.Student1MathStatus(time));
            StudentStatus.Add(ReportFunction.Student1ScienceStatus(time));
            StudentStatus.Add(ReportFunction.Student1HistoryStatus(time));
            StudentStatus.Add(ReportFunction.Student2MathStatus(time));
            StudentStatus.Add(ReportFunction.Student2ScienceStatus(time));
            StudentStatus.Add(ReportFunction.Student2HistoryStatus(time));

            DataTable table = new DataTable("MyDataTable");
            table.Columns.Add("Student no.", typeof(string));
            table.Columns.Add("Math", typeof(string));
            table.Columns.Add("Science", typeof(string));
            table.Columns.Add("History", typeof(string));


            // Add some data rows
            table.Rows.Add("2024-00001-BN-0", StudentStatus[0], StudentStatus[1], StudentStatus[2]);
            table.Rows.Add("2024-00002-BN-0", StudentStatus[3], StudentStatus[4], StudentStatus[5]);


            Console.WriteLine(" ***************** Student Attendance Report **************** ");
            Console.WriteLine("-" + new string('-', 60));
            Console.Write("{0, -18} {1, -13} {2, -13} {3, -13}", "Student no.", "Math", "Science", "History");
            Console.WriteLine("\n-" + new string('-', 60));

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine("{0, -18} {1, -13} {2, -13} {3, -13}",
                        row["Student no."], row["Math"], row["Science"], row["History"]);
            }
            Console.WriteLine("-" + new string('-', 60));
        }
    }
}
