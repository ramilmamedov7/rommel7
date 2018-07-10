using System;
using System.Media;
using System.IO;

namespace WoorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Working With Files";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            //Opens default music player app on your system.
            System.Diagnostics.Process.Start(@"D:\Drive\Paradise.wav");

            #region SoundPlayer [Plays music in console.]
            var Music = new SoundPlayer();
            //Give source to your music file.
            string Path = @"D:\Drive\Slide.wav";
            Music.SoundLocation = Path;
            Music.Play();
            Console.Read();
            #endregion

            #region New Document
            //Give source to your text file.
            var Document = new StreamWriter(@"D:\Drive\text.txt");
            string Words;
            Console.WriteLine("Please write your message: ");
            Words = Console.ReadLine();
            Document.WriteLine(Words);
            Document.Close();
            #endregion
        }
    }
}
