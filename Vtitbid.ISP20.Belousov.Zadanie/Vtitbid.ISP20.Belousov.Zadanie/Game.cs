using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Belousov.Zadanie
{
    public class Game
    {
        public string scissors = "1"; //ножницы -> бумага
        public string paper = "2"; //бумага -> камень
        public string stone = "3"; //камень -> ножницы

        Random random = new Random();
        int numberUser = 0;

        string signPC = "";
        public void PlayGame()
        {
            Console.WriteLine("Введите: \nКамень\nНожницы\nБумага");
            string signUser = Console.ReadLine().Trim();
            int numberPC = random.Next(1, 4);
            switch (signUser)
            {
                case "ножницы":
                    numberUser = 1;
                    break;
                case "бумага":
                    numberUser = 2;
                    break;
                case "камень":
                    numberUser = 3;
                    break;
            }
            switch (numberPC)
            {
                case 1:
                    signPC = "ножницы";
                    break;
                case 2:
                    signPC = "камень";
                    break;
                case 3:
                    signPC = "бумага";
                    break;
            }
            if (numberUser == 1 && numberPC == 1)
            {
                Console.WriteLine($"Ничья! Противник выбрал: {signPC} ");
            }
            if (numberUser == 1 && numberPC == 2)
            {
                Console.WriteLine($"Вы проиграли! Противник выбрал: {signPC}");
            }
            if (numberUser == 1 && numberPC == 3)
            {
                Console.WriteLine($"Вы выйграли! Противник выбрал: {signPC}");
            } // ножницы

            if (numberUser == 2 && numberPC == 1)
            {
                Console.WriteLine($"Вы проиграли! Противник выбрал: {signPC}");
            }
            if (numberUser == 2 && numberPC == 2)
            {
                Console.WriteLine($"Вы выйграли! Противник выбрал: {signPC}");
            }
            if (numberUser == 2 && numberPC == 3)
            {
                Console.WriteLine($"Ничья! Противник выбрал: {signPC} ");
            } // бумага

            if (numberUser == 3 && numberPC == 1)
            {
                Console.WriteLine($"Вы выйграли! Противник выбрал: {signPC}");
            }
            if (numberUser == 3 && numberPC == 2)
            {
                Console.WriteLine($"Ничья! Противник выбрал: {signPC} ");
            }
            if (numberUser == 3 && numberPC == 3)
            {
                Console.WriteLine($"Вы проиграли! Противник выбрал: {signPC}");
            } // камень
        }
    }
}
