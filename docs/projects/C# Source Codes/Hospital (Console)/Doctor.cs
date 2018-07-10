using System;
using System.Collections.Generic;

namespace Hospital
{
    class Doctor
    {
        public string DoctorName;
        List<string> AvailableHList = new List<string>();

        public Doctor()
        {
        }
        public Doctor(string name)
        {
            this.DoctorName = name;
        }

        public void AddAvailableHours()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            AvailableHList.Add("(08:00 - 10:00) Full");
            AvailableHList.Add("(10:00 - 12:00) Empty");
            AvailableHList.Add("(12:00 - 14:00) Full");
            AvailableHList.Add("(14:00 - 16:00) Full");
            AvailableHList.Add("(16:00 - 18:00) Empty");
        }
        public void showAvailableH()
        {
            for (int i = 0; i < AvailableHList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + AvailableHList[i]);
            }
        }
        public void chooseAvailableH(int chooseHourse)
        {
            for (int i = 0; i < AvailableHList.Count; i++)
            {
                if (chooseHourse - 1 == i)
                {

                    if (AvailableHList[i].Contains("Full"))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("\nThe doctor is busy at this time. \nPlease select another time for meeting...\n\nPress `A` to go back to department.\nPress `B` to show doctor's available hours again.");
                    }
                    if (AvailableHList[i].Contains("Empty"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("\nThank you. You reserved.\n");
                    }
                    else
                    {
                        AvailableHList[i] = AvailableHList[i].Replace("Empty", "Full");
                    }
                }
            }
        }
    }
}
