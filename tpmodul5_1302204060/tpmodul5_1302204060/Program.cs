using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo a = new SayaTubeVideo("Tutorial Design By Contract – [RIZKY EVENTA BAHTIAR]");
            a.PrintVideoDetails();
            a.IncreasePlayCount(1);
            a.PrintVideoDetails();
        }
    }
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string a)
        {
            // Instantiate random number generator using system-supplied value as seed.
            Random b = new Random();

            // Generate and display 5 random integers.
            Console.WriteLine("Five random integer values:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,15:N0}", b.Next());
            Console.WriteLine();

            this.id = b.Next();
            this.title = a;
            playCount = 0;
        }
        public void IncreasePlayCount(int a)
        {
            playCount += a;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("id :" + id);
            Console.WriteLine("Title :" + title);
            Console.WriteLine("PlayCount : " + playCount);
            Console.WriteLine();
        }
    }
}