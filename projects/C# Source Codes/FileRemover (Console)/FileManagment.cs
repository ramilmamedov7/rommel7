using System;
using System.IO;

namespace FileRemover
{
    class FileManagment
    {
        //Directory's info
        private string Folder;
        private string[] AllFiles;
        private string[] FoundedFiles = new String[80];
        // Encapsulation
        public string[] GetAllFiles
        {
            get
            {
                return this.AllFiles;
            }
        }
        //Constructor
        public FileManagment(string Folder)
        {
            this.Folder = Folder;
        }
        //Finding files and making decision to delete or not
        public void FoundFiles()
        {
            this.AllFiles = Directory.GetFiles(this.Folder, "*.*", SearchOption.AllDirectories);
            int count = 0;

            Console.WriteLine("\nDo you want to delete these files in this directory? Enter 1 or 2;\n");
            foreach (string File in this.AllFiles)
            {
                FileInfo Props = new FileInfo(File);
                DateTime Now = DateTime.Now;
                DateTime FileData = new DateTime(Props.LastAccessTime.Year, Props.LastAccessTime.Month, Props.LastAccessTime.Day, Props.LastAccessTime.Hour, Props.LastAccessTime.Minute, Props.LastAccessTime.Second);
                double Difference = Now.Subtract(FileData).TotalDays;

                if (Difference > -1)
                {
                    FoundedFiles[count] = Props.FullName.ToString();
                    count++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Last access date : [" + FileData + "] " + " File's path: " + "\"" + Props.FullName.ToString() + "\"");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n1. Yeah. | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2. Nope.\n>>>: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Delete Metod
        public void DeleteAllFiles()
        {
            foreach (string single in this.FoundedFiles)
            {
                if (!String.IsNullOrEmpty(single))
                {
                    File.Delete(single);
                }
            }
        }
    }
}
