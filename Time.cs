using System;

namespace sisapOOP
{
    class Time
    {
        //field
        private int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;

        //properties
        public int Year {
            get { return year; }
            set { year = value; }
        }

        public int Month {
            get { return month; }
            set { month = value; }
        }

        public int Date {
            get { return date; }
            set { date = value; }
        }

        public int Hour {
            get { return hour; }
            set { hour = value; }
        }

        public int Minute {
            get { return minute; }
            set { minute = value; }
        }
        public int Second {
            get { return second; }
            set { second = value; }
        }

        //constructor
        public Time()
        {
            year = 2019;
            month = 4;
            date = 9;
            hour = 14;
            minute = 35;
            second = 12;
        }

        //overlord constructor
        public Time(int year, int month, int date, int hour, int minute, int second)
        {
            this.year = year;
            this.month = month;
            this.date = date;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        //public methods
        public void DisplayCurrentTime()
        {
            Console.WriteLine("Waktu Sekarang : {0}", DateTime.Now.ToString());
        }
    }
}
