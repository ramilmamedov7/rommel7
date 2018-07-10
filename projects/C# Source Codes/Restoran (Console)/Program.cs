using System;
using System.Text;

namespace Restoran
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Restoran";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Restoranımıza xoş gəlmisiniz!\n");
            Console.ForegroundColor = ConsoleColor.White;
            int choice, piece;
            double total, sum = 0;
            Console.WriteLine("Menu:" + "\nYeməklər " + new string('-', 31) + " İçkilər");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1.Salat. - [1.5AZN] " + new string('-', 20) + " 5.Su.    - [0.5AZN]\n2.Kabab. - [3.5AZN] " + new string('-', 20) + " 6.Ayran. - [0.7AZN]\n3.Şorba. - [1.7AZN] " + new string('-', 20) + " 7.Kola.  - [1.0AZN]\n4.Dönər. - [1.2AZN] " + new string('-', 20) + " 8.Çay.   - [0.5AZN]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("0.Programı bağla.");
            void MainMethod(string name, double price)
            {
                Console.WriteLine("Neçə pors {0} istəyirsiniz?", name);
                piece = Convert.ToInt32(Console.ReadLine());
                total = piece * price;
                sum = sum + total;
            }
            for (int i = 1; i < 100; i++)
            {
                Console.Write("\n>>Seçəcəyiniz məhsulun nömrəsini qeyd edin: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                    MainMethod("salat", 1.5);
                else if (choice == 2)
                    MainMethod("kabab", 3.5);
                else if (choice == 3)
                    MainMethod("sup", 1.7);
                else if (choice == 4)
                    MainMethod("dönər", 1.2);
                else if (choice == 5)
                    MainMethod("su", 0.5);
                else if (choice == 6)
                    MainMethod("ayran", 0.7);
                else if (choice == 7)
                    MainMethod("kola", 1.0);
                else if (choice == 8)
                    MainMethod("çay", 0.5);
                else if (choice == 0)
                {
                    Console.WriteLine("\nTəşəkkürlər. Çıxış üçün hər hansı bir düyməni basın.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                Console.WriteLine("\nZəhmət olmasa mövcud variantlardan birini seçin.\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Başqa bir istəyiniz varmı? (yes/no)");
                Console.ForegroundColor = ConsoleColor.White;
                string answer = Console.ReadLine();
                if (answer == "no" || answer == "n" || answer == "N" || answer == "NO" || answer == "No")
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n**Toplam borcunuz " + sum + "AZN-dir.**");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nÖdəyəcəyiniz məbləği daxil edin (AZN): ");
            double money = Convert.ToDouble(Console.ReadLine());
            if (money > sum)
            {
                var result = money - sum;
                Console.WriteLine("Qalıq: " + result + "AZN");
                Console.WriteLine("\nTəşəkkürlər. Çıxış üçün hər hansı bir düyməni basın.");
            }
            else
            {
                Console.WriteLine("Qabları yu! :D");
            }
            Console.ReadLine();
        }
    }
}