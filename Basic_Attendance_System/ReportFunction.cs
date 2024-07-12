using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Attendance_System
{
    internal class ReportFunction
    {
        public static string Student1MathStatus(DateTime time)
        {
            int menu = 0;
            DateTime mathTime = Attendance.Student1Math();
            string mathStatus = AttendanceFunction.StudentStatus(mathTime, menu);

            return mathStatus;
        }
        public static string Student1ScienceStatus(DateTime time)
        {
            int menu = 1;
            DateTime scienceTime = Attendance.Student1Science();
            string scienceStatus = AttendanceFunction.StudentStatus(scienceTime, menu);

            return scienceStatus;
        }
        public static string Student1HistoryStatus(DateTime time)
        {
            int menu = 2;
            DateTime historyTime = Attendance.Student1History();
            string hidtoryStatus = AttendanceFunction.StudentStatus(historyTime, menu);

            return hidtoryStatus;
        }
        public static string Student2MathStatus(DateTime time)
        {
            int menu = 0;
            DateTime mathTime = Attendance.Student2Math();
            string mathStatus = AttendanceFunction.StudentStatus(mathTime, menu);

            return mathStatus;
        }
        public static string Student2ScienceStatus(DateTime time)
        {
            int menu = 1;
            DateTime scienceTime = Attendance.Stud2Science();
            string scienceStatus = AttendanceFunction.StudentStatus(scienceTime, menu);

            return scienceStatus;
        }
        public static string Student2HistoryStatus(DateTime time)
        {
            int menu = 2;
            DateTime historyTime = Attendance.Student2History();
            string hidtoryStatus = AttendanceFunction.StudentStatus(historyTime, menu);

            return hidtoryStatus;
        }
    }
}
