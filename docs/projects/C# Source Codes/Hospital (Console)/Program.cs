using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hospital";            
            Console.WriteLine("Please enter your name: ");
            string cutomerName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWelcome to the Hospital " + cutomerName + "!");
            var NewPat = new Patient(cutomerName);
            var NewDep = new Department();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPlease choose the one department you need: \n");
            NewDep.AddDepartments();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            NewDep.ShowDepartments();
            Console.WriteLine();
            string chooseShobe = Console.ReadLine();
            NewDep.AddDoctors(chooseShobe);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nDoctors of number [{0}] department are shown below. \nPlease select your doctor: \n", chooseShobe);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            NewDep.ShowDoctors();
            var NewDoc = new Doctor();
            Console.WriteLine();
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPlease reserve time for a meeting: \n");
            NewDoc.AddAvailableHours();
            NewDoc.showAvailableH();
            Console.WriteLine();
            int chooseHourse = Convert.ToInt32(Console.ReadLine());
            NewDoc.chooseAvailableH(chooseHourse);
            if (Console.ReadKey(true).Key == ConsoleKey.A)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                Console.WriteLine();
                NewDep.ShowDepartments();
            }
            if (Console.ReadKey(true).Key == ConsoleKey.B)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                NewDoc.showAvailableH();
                Console.Read();
            }
        }
    }
}