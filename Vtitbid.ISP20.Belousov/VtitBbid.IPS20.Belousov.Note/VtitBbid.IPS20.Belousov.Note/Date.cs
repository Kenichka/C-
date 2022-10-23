using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtitBbid.IPS20.Belousov.Note
{
    public class Date
    {
        private int _Day { get; set; }
        private int _Month { get; set; }
        private int _Year { get; set; }
        public int DayOfBirth
        {
            get
            {
                return _Day;
            }
            set
            {
                if (value > 0 && value <= 31)
                {

                    _Day = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода даты");
                    Console.ResetColor();
                    Environment.Exit(0);
                }
            }
        }
        public int MonthOfBirth
        {
            get
            {
                return _Month;
            }
            set
            {
                if (value > 0 && value < 12)
                {
                    _Month = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода даты");
                    Console.ResetColor();
                    Environment.Exit(0);
                }
            }
        }
        public int YearOfBirth
        {
            get
            {
                return _Year;
            }
            set
            {
                if (value > 1000 && value <= Convert.ToInt32(DateTime.Now.Year))
                {
                    _Year = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода даты");
                    Console.ResetColor();
                    Environment.Exit(0);
                }
            }
        }
        public Date(int dayOfBirth, int monthOfBirth, int yearOfBirth)
        {
            DayOfBirth = dayOfBirth;
            MonthOfBirth = monthOfBirth;
            YearOfBirth = yearOfBirth;
        }
        public static Date CreateDate()
        {
            Console.WriteLine("Введите дату рождения ");
            int dayOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц рождения ");
            int monthOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год рождения ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            return new Date(dayOfBirth, monthOfBirth, yearOfBirth);
        }
    }
}
