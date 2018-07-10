using System;
using System.Collections.Generic;

namespace Taxi
{
    class Order
    {
        //Orders Info
        public string fullName { get; set; }
        public int startPointX, startPointY, endPointX, endPointY;
        static double distance, taxiDistance;
        private int time, travelTimeOfTaxi;
        private double money;

        public void Customer()
        {
            Console.WriteLine("Please enter your name: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Add your coordinates (X): ");
            startPointX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add your coordinates (Y): ");
            startPointY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add coordinates of your destination (X): ");
            endPointX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add coordinates of your destination (Y): ");
            endPointY = Convert.ToInt32(Console.ReadLine());
        }

        //Calculations
        public double DistanceCalculator()
        {
            distance = Math.Sqrt(Math.Pow((endPointX * 1000 - startPointX * 1000), 2) + Math.Pow((endPointY * 1000 - endPointY * 1000), 2));
            return distance;
        }
        public double CalculateMoney()
        {
            money = DistanceCalculator() * 2 / 10000;
            return money;
        }
        public int TimeCalculator()
        {
            time = Convert.ToInt32(DistanceCalculator() / 3000);
            return time;
        }
        public int CalculateTravelTimeOfTaxi(Taxi randomTaxi)
        {
            taxiDistance = Math.Sqrt(Math.Pow((startPointX * 1000 - randomTaxi.taxiCoorX * 1000), 2) + Math.Pow((startPointY * 1000 - randomTaxi.taxiCoorY), 2));
            travelTimeOfTaxi = Convert.ToInt32(taxiDistance / 3000);
            return travelTimeOfTaxi;
        }
        //Constructor
        public Order()
        {
            ChooseTaxi();
            Customer();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + "Hormetli {0} sizin taksiniz teyin edildi." + "\n" + "Taksiniz {1} deqiqeye adresinizde olacaq, " + "qeyd etdiyiniz adrese catma vaxtiniz {2} deqiqe. " + "\n" + "Gedish haqqiniz {3}[AZN] olacaqdir." + "\n" + "Size xidmet edecek surucu {4}." + "\n" + "\n", fullName, CalculateTravelTimeOfTaxi(ChooseTaxi()), TimeCalculator().ToString(), CalculateMoney().ToString(), ChooseTaxi().driverName);
            Console.ReadLine();
        }
        //Choosing nearest Taxi Driver
        public Taxi ChooseTaxi()
        {
            Taxi Driver1 = new Taxi("Bibish", 50, 50);
            Taxi Driver2 = new Taxi("Yumosh", 30, 20);
            Taxi Driver3 = new Taxi("Cappy", 70, 90);
            Taxi Driver4 = new Taxi("Imish", 40, 40);

            Taxi chosenTaxi = Driver1;
            List<Taxi> DriversList = new List<Taxi>();
            DriversList.Add(Driver1);
            DriversList.Add(Driver2);
            DriversList.Add(Driver3);
            DriversList.Add(Driver4);

            int choose = CalculateTravelTimeOfTaxi(DriversList[0]);

            for (int i = 0; i < DriversList.Count; i++)
            {
                if (choose > CalculateTravelTimeOfTaxi(DriversList[i]))
                {
                    choose = CalculateTravelTimeOfTaxi(DriversList[i]);
                    chosenTaxi = DriversList[i];
                }
            }
            return chosenTaxi;
        }
    }
}
