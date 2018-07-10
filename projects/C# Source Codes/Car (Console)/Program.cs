using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Avtomobil";
            Car Mustang = new Car("Ford Mustang", 60, 13, 40);
            string selection;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("İdarə etdiyiniz avtomobil '{0}'-dır. Avtomobilin benzin çəninin tutumu {1}-litrdir.\n100km-ə sərf etdiyi benzinin miqdarı {2}-litrdir. Çəndə hal-hazırda {3}-litr benzin var.\n", Mustang.CarName, Mustang.FuelCapacity, Mustang.FuelEfficiency, Mustang.CurrentFuel);
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.WriteLine("1. Sür.");
                Console.WriteLine("2. Benzin çənini doldur.");
                Console.WriteLine("3. Gedilən lokal məsafəni göstər.");
                Console.WriteLine("4. Gedilən qlobal məsafəni göstər.");
                Console.WriteLine("0. Programı bağla.");
                Console.Write(">>>>> Seçiminizi edin: ");

                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Mustang.Drive();
                        break;
                    case "2":
                        Mustang.Fill();
                        break;
                    case "3":
                        Mustang.ZeroLocal();
                        break;
                    case "4":
                        Mustang.ShowGlobal();
                        break;
                    case "0":
                        Console.WriteLine();
                        Console.WriteLine("Təşəkkürlər. Çıxış üçün hər hansı bir düyməni basın.");
                        Console.WriteLine(new string('-', 52));
                        Console.ReadKey();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nZəhmət olmasa mövcud variantlardan birini seçin.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (selection != "0");
        }
    }
}
