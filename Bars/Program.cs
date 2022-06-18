using System;
using System.IO;
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
        internal static item[] inventory = new item[6];
        internal static decimal Points = 1;
        internal static decimal tPoints = 1;
        internal static ushort barsp = 1;
        internal static decimal level = 1;
        internal static decimal levelp = 1;
        internal static decimal leveln = 2;
        internal static byte speedboost = 1;
        internal static byte resourceboost = 1;
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
            else if (option == ConsoleKey.D2)
            {
                NormalMode();
            }
            else if (option == ConsoleKey.D3)
            {
                MediumMode();
            }
            else if (option == ConsoleKey.D4)
            {
                HardMode();
            }
            else if (option == ConsoleKey.D5)
            {
                VeryHardMode();
            }
            else if (option == ConsoleKey.D6)
            {
                ExtremeMode();
            }
            else if (option == ConsoleKey.D7)
            {
                InsaneMode();
            }
            else if(option == ConsoleKey.Insert)
            {
                debug = true;
                Console.Clear();
                Console.WriteLine("Debug Mode Active");
                Thread.Sleep(1000);
                Main();
            }
            else
            {
                Main();
            }
        }

        internal static void InsaneMode()
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
                    if (tPoints > (level * 100))
                    {
                        level++;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
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
                    if (Points >= (barsp * 4))
                    {
                        Points -= (barsp * 4);
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

        internal static void ExtremeMode()
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
                    if (tPoints > (level * 100))
                    {
                        level++;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
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
                    if (Points >= (barsp * 4))
                    {
                        Points -= (barsp * 4);
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

        internal static void VeryHardMode()
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
                    if (tPoints > (level * 100))
                    {
                        level++;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
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
                    if (Points >= (barsp * 4))
                    {
                        Points -= (barsp * 4);
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

        internal static void HardMode()
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
                    if (tPoints > (level * 100))
                    {
                        level++;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
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
                    if (Points >= (barsp * 4))
                    {
                        Points -= (barsp * 4);
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

        internal static void MediumMode()
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
                    if (tPoints > (level * 100))
                    {
                        level++;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
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
                    if (Points >= (barsp * 4))
                    {
                        Points -= (barsp * 4);
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

        internal static void NormalMode()
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
                    if (tPoints > (level * 100))
                    {
                        level++;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
            while (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
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
                    if (Points >= (barsp * 4))
                    {
                        Points -= (barsp * 4);
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

        internal static void AutoMode()
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
                    if (tPoints >= (level * 100))
                    {
                        level++;
                    }
                    if (Points >= (barsp * 4))
                    {
                        Points -= (barsp * 4);
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
        internal static void WriteInventory()
        {
            speedboost = 1;
            resourceboost = 1;
            for(int i = inventory.Length;i >= 0; i--)
            {
                if(inventory[i].type == 0)
                {
                    Console.WriteLine(Properties.Resources.slot);
                }
                if (inventory[i].type == 1)
                {
                    Console.WriteLine(Properties.Resources.speedslot);
                    speedboost++;
                }
                if (inventory[i].type == 2)
                {
                    Console.WriteLine(Properties.Resources.collection);
                    resourceboost++;
                }
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
            i += Program.speedboost;
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
            i += Program.speedboost;
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
                return (Program.levelp * Program.level * Program.resourceboost) / 2;
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
            i += Program.speedboost;
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
                return (Program.level * Program.resourceboost * Program.level) / 2;
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
            i += Program.speedboost;
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
                return (Program.levelp * Program.resourceboost * Program.level) / 4;
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
            i += Program.speedboost;
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
                return (Program.levelp * Program.resourceboost * Program.level) / 8;
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
            i+=Program.speedboost;
            return 0;
        }
    }
    internal struct item
    {
        internal byte type;
    }
}
