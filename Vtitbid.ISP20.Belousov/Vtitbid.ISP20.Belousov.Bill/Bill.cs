using System.Transactions;

namespace Vtitbid.ISP20.Belousov.Bill
{
    class Bill
    {
        private double _PayersCurrentAccount { get; set; }
        private double _Recipient { get; set; }
        private double _AmountTransferred { get; set; }
        public double PayerAccount
        {
            get
            {
                return _PayersCurrentAccount;
            }
            set
            {
                if (value > 0)
                {
                    _PayersCurrentAccount = value;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода номера расчётного счёта плательщика");
                }
            }
        }
        public double RecipientAccount
        {
            get
            {
                return _Recipient;
            }
            set
            {
                if (value > 0)
                {
                    _Recipient = value;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода номера расчётного счёта получателя");
                }
            }
        }
        public double Amount
        {
            get
            {
                return _AmountTransferred;
            }
            set
            {
                if (value > 0)
                {
                    _AmountTransferred = value;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода суммы");
                }
            }

        }

        public Bill(double payerAccount, double recipientAccount, double amount)
        {
            PayerAccount = payerAccount;
            RecipientAccount = recipientAccount;
            Amount = amount;
        }

        public static void CreatingArray(out int lenght)
        {
            Console.WriteLine("Введите количество человек: ");
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
        public static Bill CreateBill()
        {
            System.Console.WriteLine("\nВведите номер расчётного счёта плательщика");
            double payerAccount = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Введите номер расчётного счёта получателя");
            double recipientAccount = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Введите перечисляемую сумму");
            double amount = Convert.ToDouble(Console.ReadLine());

            return new Bill(payerAccount, recipientAccount, amount);
        }
        public static string ArrayOutput(Bill[] arrayBills)
        {
            string output = "\nСписок людей: ";
            for (int i = 0; i < arrayBills.Length; i++)
            {
                output += $"\nНомер расчётного счёта плательщика:{arrayBills[i].PayerAccount,-12} Номер расчётного счёта получателя:{arrayBills[i].RecipientAccount,-12} Перечисляемая сумма:{arrayBills[i].Amount}рублей ";

            }
            return output;
        }
    }
}