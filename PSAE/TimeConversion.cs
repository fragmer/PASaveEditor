using System;

namespace PASaveEditor {
    internal static class TimeConversion {
        const int MinutesPerDay = 60*24,
            MinutesPerHour = 60;


        public static int IndexToDay(double seconds) {
            return (int)Math.Floor(seconds/MinutesPerDay) + 1;
        }


        public static int IndexTo12Hour(double seconds) {
            int hours = (int)Math.Floor(seconds)%MinutesPerDay/MinutesPerHour%12;
            if (hours == 0) return 12;
            else return hours;
        }


        public static int IndexToMinute(double seconds) {
            return (int)Math.Floor(seconds)%MinutesPerHour;
        }


        public static bool IsPm(double seconds) {
            int hours = (int)Math.Floor(seconds)%MinutesPerDay/MinutesPerHour;
            return hours > 11;
        }


        public static double ToIndex(int day, string timeString, bool isPm) {
            string[] timeParts = timeString.Split(':');
            int hour = Int32.Parse(timeParts[0]);
            int minute = Int32.Parse(timeParts[1]);
            if (hour == 12) hour = 0;
            if (isPm) hour += 12;
            return (double)(day - 1)*MinutesPerDay + (double)hour*MinutesPerHour + minute;
        }
    }
}
