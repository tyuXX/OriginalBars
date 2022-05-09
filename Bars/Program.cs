using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bars
{
    internal static class Program
    {
        internal static Bar[] bars = new Bar[(ushort.MaxValue - 100)];
        internal static int Points = 1;
        internal static int tPoints = 1;
        internal static int barsn = 2;
        internal static ushort barsp = 1;
        internal static int level = 1;
        internal static int levelcn = 100;
        internal static int levelp = 1;
        internal static int leveln = 2;
        static void Main(string[] args)
        {
            Console.Title = "Bars";
            while (true)
            {
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Level:" + level);
                Console.WriteLine("Multipilier:" + levelp);
                for (int i = 0; i < barsp; i++)
                {
                    int get = bars[i].BarTick();
                    Points += get;
                    tPoints += get;
                    if(tPoints > levelcn)
                    {
                        level++;
                        levelcn *= 2;
                    }
                    if(Points > barsn)
                    {
                        Points -= barsn;
                        barsn *= 2;
                        barsp++;
                    }
                    if (Points > leveln)
                    {
                        Points -= leveln;
                        leveln *= 2;
                        levelp++;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
        }
    }
    internal struct Bar
    {
        internal int i;
        internal int BarTick()
        {
            if(i > 99)
            {
                i = 0;
                return Program.levelp * Program.level;
            }
            int written = 0;
            Console.Write("[");
            for (int y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (int y = (100 - written); y > 0; y--)
            {
                Console.Write(" ");
            }
            Console.Write("]" + (i + 1 + " / 100\n"));
            i++;
            return 0;
        }
    }
}
