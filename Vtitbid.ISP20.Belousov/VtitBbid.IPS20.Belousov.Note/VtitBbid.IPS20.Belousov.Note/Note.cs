using VtitBbid.IPS20.Belousov.Note;

namespace Vtitvid.ISP20.Belousov.Note
{

    public class Note
    {

        public string LastName { get; set; }
        public string FirstName { get; set; } 
        public string PhoneNumber { get; set; }
        public Date DateOfBirth { get; set; }



        public Note(string firstName, string lastName, string phoneNumber,Date dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
        }

        public static Note CreateNote()
        {
            System.Console.WriteLine("\nВведите имя ");
            string firstName = Console.ReadLine();

            System.Console.WriteLine("Введите фамилию ");
            string lastName = Console.ReadLine();

            System.Console.WriteLine("Введите номер телефона ");
            string phoneNumber = Console.ReadLine();

            Date date = Date.CreateDate();

            return new Note(firstName, lastName, phoneNumber,date);
        }
        public static void CreatingArray(out int lenght)
        {
            Console.WriteLine("ВВедите количество человек: ");
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
        public static string ArrayOutput(Note[] array)
        {
            string output = "\nСписок людей: ";
                for (int i = 0; i < array.Length; i++)
                {
                output += $"\nФамилия: {array[i].LastName,-5} Имя: {array[i].FirstName,-5} Дата рождение: {array[i].DateOfBirth.DayOfBirth}.{array[i].DateOfBirth.MonthOfBirth}.{array[i].DateOfBirth.YearOfBirth} Телефон: {array[i].PhoneNumber} ";
                }
            return output;
        }

    }
}
