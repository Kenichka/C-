using System.Security.Cryptography.X509Certificates;

namespace Vtitbid.ISP20.Belousov.Price
{
    class Price
    {
        private string _ProductName { get; set; }
        private string _ShopName { get; set; }
        private double _ProductPrice { get; set; }
        public string ProductName
        {
            get 
            { 
                return _ProductName; 
            }
            set
            {
                if ((!string.IsNullOrEmpty(value)))
                {
                    _ProductName = value;
                }
                else
                {
                    Console.WriteLine("ошибка ввода данных");
                }
            }

        }
        public string StoreName
        {
            get { return _ShopName; }
            set
            {
                if ((!string.IsNullOrEmpty(value)))
                {
                    _ShopName = value;
                }
                else
                {
                    Console.WriteLine("ошибка ввода данных");
                }
            }
        }
        public double ProductPrice
        {
            get { return _ProductPrice; }
            set
            {
                if (value > 0)
                {
                    _ProductPrice = value;
                }
                else
                {
                    Console.WriteLine("ошибка ввода данных");
                }
            }
        }
        public Price(string productName, string storeName, double productPrice)
        {
            ProductName = productName;
            StoreName = storeName;
            ProductPrice = productPrice;
        }
        public static Price CreatePrice()
        {
            Console.WriteLine("\nВведите название товара ");
            string productName = Console.ReadLine();

            System.Console.WriteLine("Введите название магазина ");
            string storeName = Console.ReadLine();

            Console.WriteLine("Введите цену продукта");
            double productPrice = Convert.ToDouble(Console.ReadLine());

            return new Price(productName, storeName, productPrice);
        }

        public static void CreatingArray(out int lenght)
        {
            Console.WriteLine("Введите количество магазинов: ");
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


        public static string ArrayOutput(Price[] array)
        {
            string output = "\nСписок магазинов: ";
            for (int i = 0; i < array.Length; i++)
            {
                output += $"\n название продукта:{array[i].ProductName,-5}  Магазин:{array[i].StoreName,-5} Цена за еденицу товара:{array[i].ProductPrice,-5} ";


            }
            return output;
        }
    }
}
