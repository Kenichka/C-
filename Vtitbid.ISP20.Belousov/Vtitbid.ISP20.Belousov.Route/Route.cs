using System;

namespace Vtitbid.ISP20.Belousov.Route
{
    class Route
    {
        public string _InitialRoute { get; set; }
        public string _FinalRoute { get; set; }
        public int NumberRoute { get; set; }

        public string InitialRoute
        {
            get
            {
                return _InitialRoute;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _InitialRoute = value;
                }
                else
                {
                    Console.WriteLine("ошибка ввода начального маршрута");
                }
            }
        }
        public string FinalRoute
        {
            get { return _FinalRoute; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _FinalRoute = value;
                }
                else
                {
                    Console.WriteLine("ошибка ввода конечного маршрута");
                }
            }
        }
        public Route(string initialRoute, string finalRoute, int numberRoute)
        {
            _InitialRoute = initialRoute;
            _FinalRoute = finalRoute;
            NumberRoute = numberRoute;
        }
        public static void CreatingArray(out int lenght)
        {
            Console.WriteLine("Введите количество маршрутов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            lenght = 0;
            if (n > 0)
            {
                lenght = n;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Количество человек должно быть больше 0");
                Console.ResetColor();
                Environment.Exit(0);
            }
        }
        public static Route CreateRoute()
        {
            System.Console.WriteLine("\nВведите номер маршрута ");
            int numberRoute = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Введите название начального пункта маршрута ");
            string initialRoute = Console.ReadLine();

            System.Console.WriteLine("Введите название конечного пункта маршрута ");
            string finalRoute = Console.ReadLine();

            return new Route(initialRoute, finalRoute, numberRoute);
        }

        public static string ArrayOutput(ref Route[] array)
        {
            string output = "\nСписок маршрутов: ";
            for (int i = 0; i < array.Length; i++)
            {
                output += $"\n{"Номер маршрута:",-2} {array[i].NumberRoute,-2} {"Название начального пункта маршрута:",-12} {array[i].InitialRoute,-15} {"Название конечного пункта маршрута:",-10} {array[i].FinalRoute} ";
            }
            return output;
        }

    }
}