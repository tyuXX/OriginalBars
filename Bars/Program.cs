using System;
using System.Threading;

namespace Bars
{
    internal static class Program
    {
        internal static BarNormal[] barsN = new BarNormal[(ushort.MaxValue - 100)];
        internal static BarMedium[] barsM = new BarMedium[(ushort.MaxValue - 100)];
        internal static BarHard[] barsH = new BarHard[(ushort.MaxValue - 100)];
        internal static BarVeryHard[] barsVH = new BarVeryHard[(ushort.MaxValue - 100)];
        internal static BarExtreme[] barsE = new BarExtreme[(ushort.MaxValue - 100)];
        internal static BarInsane[] barsI = new BarInsane[(ushort.MaxValue - 100)];
        internal static decimal Points = 1;
        internal static decimal tPoints = 1;
        internal static decimal barsn = 2;
        internal static ushort barsp = 1;
        internal static decimal level = 1;
        internal static decimal levelcn = 100;
        internal static decimal levelp = 1;
        internal static decimal leveln = 2;
        internal static bool debug = false;
        static void Main()
        {
            Console.Title = "Bars";
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.WriteLine("Please Select Gamemode:\n[1]Auto\n[2]Normal\n[3]Medium\n[4]Hard\n[5]Very Hard\n[6]Extreme\n[7]Insane");
            ConsoleKey option = Console.ReadKey(true).Key;
            if (option == ConsoleKey.D1)
            {
                AutoMode();
            }
            if (option == ConsoleKey.D2)
            {
                NormalMode();
            }
            if (option == ConsoleKey.D3)
            {
                MediumMode();
            }
            if (option == ConsoleKey.D4)
            {
                HardMode();
            }
            if (option == ConsoleKey.D5)
            {
                VeryHardMode();
            }
            if (option == ConsoleKey.D6)
            {
                ExtremeMode();
            }
            if (option == ConsoleKey.D7)
            {
                InsaneMode();
            }
            if(option == ConsoleKey.Insert)
            {
                debug = true;
                Console.Clear();
                Console.WriteLine("Debug Mode Active");
                Thread.Sleep(1000);
                Main();
            }
        }

        private static void InsaneMode()
        {
            while (!Console.KeyAvailable)
            {
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Level:" + level);
                Console.WriteLine("Multipilier:" + levelp);
                for (int i = 0; i < barsp; i++)
                {
                    decimal get = barsI[i].BarTick();
                    Points += get;
                    tPoints += get;
                    if (tPoints > levelcn)
                    {
                        level++;
                        levelcn *= 2;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + barsn + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 2;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
                if (option == ConsoleKey.D2)
                {
                    if (Points >= barsn)
                    {
                        Points -= barsn;
                        barsn *= 2;
                        barsp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Bar.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
            }
            InsaneMode();
        }

        private static void ExtremeMode()
        {
            while (!Console.KeyAvailable)
            {
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Level:" + level);
                Console.WriteLine("Multipilier:" + levelp);
                for (int i = 0; i < barsp; i++)
                {
                    decimal get = barsE[i].BarTick();
                    Points += get;
                    tPoints += get;
                    if (tPoints > levelcn)
                    {
                        level++;
                        levelcn *= 2;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + barsn + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 2;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
                if (option == ConsoleKey.D2)
                {
                    if (Points >= barsn)
                    {
                        Points -= barsn;
                        barsn *= 2;
                        barsp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Bar.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
            }
            ExtremeMode();
        }

        private static void VeryHardMode()
        {
            while (!Console.KeyAvailable)
            {
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Level:" + level);
                Console.WriteLine("Multipilier:" + levelp);
                for (int i = 0; i < barsp; i++)
                {
                    decimal get = barsVH[i].BarTick();
                    Points += get;
                    tPoints += get;
                    if (tPoints > levelcn)
                    {
                        level++;
                        levelcn *= 2;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + barsn + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 2;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
                if (option == ConsoleKey.D2)
                {
                    if (Points >= barsn)
                    {
                        Points -= barsn;
                        barsn *= 2;
                        barsp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Bar.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
            }
            VeryHardMode();
        }

        private static void HardMode()
        {
            while (!Console.KeyAvailable)
            {
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Level:" + level);
                Console.WriteLine("Multipilier:" + levelp);
                for (int i = 0; i < barsp; i++)
                {
                    decimal get = barsH[i].BarTick();
                    Points += get;
                    tPoints += get;
                    if (tPoints > levelcn)
                    {
                        level++;
                        levelcn *= 2;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + barsn + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 2;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
                if (option == ConsoleKey.D2)
                {
                    if (Points >= barsn)
                    {
                        Points -= barsn;
                        barsn *= 2;
                        barsp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Bar.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
            }
            HardMode();
        }

        private static void MediumMode()
        {
            while (!Console.KeyAvailable)
            {
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Level:" + level);
                Console.WriteLine("Multipilier:" + levelp);
                for (int i = 0; i < barsp; i++)
                {
                    decimal get = barsM[i].BarTick();
                    Points += get;
                    tPoints += get;
                    if (tPoints > levelcn)
                    {
                        level++;
                        levelcn *= 2;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + barsn + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 2;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
                if (option == ConsoleKey.D2)
                {
                    if (Points >= barsn)
                    {
                        Points -= barsn;
                        barsn *= 2;
                        barsp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Bar.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
            }
            MediumMode();
        }

        private static void NormalMode()
        {
            while (!Console.KeyAvailable)
            {
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Level:" + level);
                Console.WriteLine("Multipilier:" + levelp);
                for (int i = 0; i < barsp; i++)
                {
                    decimal get = barsN[i].BarTick();
                    Points += get;
                    tPoints += get;
                    if (tPoints > levelcn)
                    {
                        level++;
                        levelcn *= 2;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + barsn + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 2;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
                if (option == ConsoleKey.D2)
                {
                    if (Points >= barsn)
                    {
                        Points -= barsn;
                        barsn *= 2;
                        barsp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Bar.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                    }
                }
            }
            NormalMode();
        }

        private static void AutoMode()
        {
            while (true)
            {
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Level:" + level);
                Console.WriteLine("Multipilier:" + levelp);
                for (int i = 0; i < barsp; i++)
                {
                    decimal get = barsN[i].BarTick();
                    Points += get;
                    tPoints += get;
                    if (tPoints >= levelcn)
                    {
                        level++;
                        levelcn *= 2;
                    }
                    if (Points >= barsn)
                    {
                        Points -= barsn;
                        barsn *= 2;
                        barsp++;
                    }
                    if (Points >= leveln)
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
    internal struct BarNormal
    {
        internal decimal i;
        internal decimal BarTick()
        {
            if(i > 99)
            {
                i = 0;
                return Program.levelp * Program.level;
            }
            decimal written = 0;
            Console.Write("[");
            for (decimal y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (decimal y = (100 - written); y > 0; y--)
            {
                Console.Write(" ");
            }
            Console.Write("]" + (i + 1 + " / 100\n"));
            i++;
            return 0;
        }
    }
    internal struct BarMedium
    {
        internal decimal i;
        internal decimal BarTick()
        {
            if (i >= 150)
            {
                i = 0;
                return Program.levelp * Program.level;
            }
            decimal written = 0;
            Console.Write("[");
            for (decimal y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (decimal y = (150 - written); y > 0; y--)
            {
                Console.Write(" ");
            }
            Console.Write("]" + (i + 1 + " / 150\n"));
            i++;
            return 0;
        }
    }
    internal struct BarHard
    {
        internal decimal i;
        internal decimal BarTick()
        {
            if (i >= 150)
            {
                i = 0;
                return (Program.levelp * Program.level) / 2;
            }
            decimal written = 0;
            Console.Write("[");
            for (decimal y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (decimal y = (150 - written); y > 0; y--)
            {
                Console.Write(" ");
            }
            Console.Write("]" + (i + 1 + " / 150\n"));
            i++;
            return 0;
        }
    }
    internal struct BarVeryHard
    {
        internal decimal i;
        internal decimal BarTick()
        {
            if (i >= 250)
            {
                i = 0;
                return (Program.levelp * Program.level) / 2;
            }
            decimal written = 0;
            Console.Write("[");
            for (decimal y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (decimal y = (250 - written); y > 0; y--)
            {
                Console.Write(" ");
            }
            Console.Write("]" + (i + 1 + " / 250\n"));
            i++;
            return 0;
        }
    }
    internal struct BarExtreme
    {
        internal decimal i;
        internal decimal BarTick()
        {
            if (i >= 300)
            {
                i = 0;
                return (Program.levelp * Program.level) / 4;
            }
            decimal written = 0;
            Console.Write("[");
            for (decimal y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (decimal y = (300 - written); y > 0; y--)
            {
                Console.Write(" ");
            }
            Console.Write("]" + (i + 1 + " / 300\n"));
            i++;
            return 0;
        }
    }
    internal struct BarInsane
    {
        internal decimal i;
        internal decimal BarTick()
        {
            if (i >= 500)
            {
                i = 0;
                return (Program.levelp * Program.level) / 8;
            }
            decimal written = 0;
            Console.Write("[");
            for (decimal y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (decimal y = (500 - written); y > 0; y--)
            {
                Console.Write(" ");
            }
            Console.Write("]" + (i + 1 + " / 500\n"));
            i++;
            return 0;
        }
    }
}
