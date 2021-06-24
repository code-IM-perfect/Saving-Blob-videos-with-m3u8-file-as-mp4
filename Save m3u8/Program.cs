using System;
using System.Diagnostics;

namespace Save_m3u8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the URL of the m3u8 file (or execute order...)");
            var link = Console.ReadLine();

            if (link == "66")
            {
                Console.WriteLine("It will be done my lord, just enter the name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter the URL of the m3u8");
                var url = Console.ReadLine();
                Command(name, url);
            }
            else
            {
                var name = link;
                Console.WriteLine("Enter the name you wanna save it with");
                var url = Console.ReadLine();
                Command(name, url);
            }
        }

        private static Process Command(string name, string url)
        {
            return Process.Start("powershell.exe", "ffmpeg -m3u8_hold_counters 3 -i " + url + " -codec copy " + name + ".mp4");
        }
    }
}
