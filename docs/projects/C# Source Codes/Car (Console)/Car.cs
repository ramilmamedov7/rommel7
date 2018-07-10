using System;
using System.Text;

namespace Car
{
    class Car
    {
        //Main fields
        private string carName;
        private int fuelCapacity;
        private double fuelEfficiency;
        private double currentFuel;
        private double localDistance;
        private double globalDistance;

        public int FuelCapacity
        {
            get
            {
                return this.fuelCapacity;
            }
        }
        public double CurrentFuel
        {
            get
            {
                return this.currentFuel;
            }
        }
        //Constructor
        public Car(string Name, int Capacity, int Efficiency, int Fuel)
        {
            this.carName = Name;
            this.fuelCapacity = Capacity;
            this.fuelEfficiency = Efficiency;
            this.currentFuel = Fuel;
        }
        public string CarName
        {
            get
            {
                return this.carName;
            }
        }
        public double FuelEfficiency
        {
            get
            {
                return this.fuelEfficiency;
            }
        }
        //Main Metod
        public void Drive()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nNeçə kilometr yol getmək istəyirsiniz: ");
            Console.ForegroundColor = ConsoleColor.White;
            double distance = Convert.ToDouble(Console.ReadLine());
            double possibleDistance = (currentFuel * 100) / fuelEfficiency;

            if (distance <= possibleDistance && distance > 0)
            {
                possibleDistance -= distance;
                currentFuel = (possibleDistance * fuelEfficiency) / 100;
                localDistance += distance;
                globalDistance += distance;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n{0}-km məsafəni qət etdiniz, çəndə {1}-litr yanacaq qalıb.\n", distance, Convert.ToSingle(currentFuel));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nBu qədər yol gedə bilməzsiniz. Çəndə olan benzinlə maksimum {0}-km yol gedə bilərsiniz.", Convert.ToSingle(possibleDistance));
                Console.ForegroundColor = ConsoleColor.White;
                Drive();
            }
        }
        //Metod for filling tank.
        public void Fill()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nÇənə neçə litr benzin əlavə edəcəyinizi bildirin: ");
            Console.ForegroundColor = ConsoleColor.White;
            double extraFuel = Convert.ToDouble(Console.ReadLine());
            double possibleFuelLevel = fuelCapacity - currentFuel;
            if (extraFuel <= possibleFuelLevel && extraFuel > 0)
            {
                currentFuel += extraFuel;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nÇənə {0}-litr benzin əlavə olundu. Hazırkı benzinin həcmi {1}-litrdir.\n", extraFuel, currentFuel);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nÇəndə hal hazırda {0}-litr benzin var. Çənin həcmi {1}-litrdir və həcmindən çox benzin doldura bilməzsiniz.", currentFuel, fuelCapacity);
                Console.ForegroundColor = ConsoleColor.White;
                Fill();
            }
        }
        //Metod for reseting Local Distance
        public void ZeroLocal()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n{0}-km yol qət etmisiniz. Sıfırlamaq istəyirsinizmi (Yes/No)? >> ", this.localDistance);
            Console.ForegroundColor = ConsoleColor.White;
            var answer = Console.ReadLine();
            if (answer == "Yes" || answer == "YES" || answer == "yes" || answer == "Y" || answer == "y")
            {
                localDistance = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nGedilən lokal məsafə sıfırlandı.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("\nLokal məsafədə dəyişiklik olmadı.\n");
            }
        }
		//Metod for displaying Global Distance
        public void ShowGlobal()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nGedilən qlobal məsafə {0}-km-dir.\n", globalDistance);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
