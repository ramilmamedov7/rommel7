using System;

namespace FileRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "File Remover";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Please copy path of the directory you want to use. " + @"(For example: 'C:\Windows\Temp')" + "\n>>>>>: ");
            Console.ForegroundColor = ConsoleColor.White;
            string Path = Console.ReadLine().Trim();
            FileManagment Directory = new FileManagment(Path);

            Directory.FoundFiles();

            string response = Console.ReadLine();
            if (response == "1")
            {
                Directory.DeleteAllFiles();
                Console.Write("\nFiles deleted. Thank you!\n");
                Console.ReadKey();
            }
            else
            {
                Console.Write("\nFiles wasn't deleted. Press any key to exit...\n");
            }
        }
    }
}
