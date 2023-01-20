using System;
using System.IO;
using System.Numerics;
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
        internal static BigInteger Points = 1;
        internal static BigInteger tPoints = 1;
        internal static ushort barsp = 1;
        internal static BigInteger level = 1;
        internal static BigInteger levelp = 1;
        internal static BigInteger leveln = 10;
        internal static byte speedboost = 1;
        internal static byte resourceboost = 1;
        internal static bool debug = false;
        internal static bool baruapdate = true;
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
                    BigInteger get = barsI[i].BarTick();
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
                baruapdate = false;
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 4;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                    BigInteger get = barsE[i].BarTick();
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
                baruapdate = false;
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 4;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                    BigInteger get = barsVH[i].BarTick();
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
                baruapdate = false;
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 4;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                    BigInteger get = barsH[i].BarTick();
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
                baruapdate = false;
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 4;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                    BigInteger get = barsM[i].BarTick();
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
                baruapdate = false;
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 4;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                    BigInteger get = barsN[i].BarTick();
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
                baruapdate = false;
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Points:" + Points);
                Console.WriteLine("Buy Upgrades:\n[1]Multipilier: " + leveln + "-Points\nCurrent:" + levelp + "\n[2]Bar: " + (barsp * 4) + "-Points\nCurrent:" + barsp);
                ConsoleKey option = Console.ReadKey(true).Key;
                if (option == ConsoleKey.D1)
                {
                    if (Points >= leveln)
                    {
                        Points -= leveln;
                        leveln *= 4;
                        levelp++;
                        Console.Clear();
                        Console.WriteLine("Purhased Multipilier.");
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                        baruapdate = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough money.");
                        baruapdate = true;
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
                    BigInteger get = barsN[i].BarTick();
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
                        leveln *= 4;
                        levelp++;
                    }
                }
                Thread.Sleep(25);
                Console.Clear();
            }
        }
        internal static void WriteInventory()
        {
            baruapdate = false;
            Thread.Sleep(500);
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
        internal static void ThreadI(int i)
        {
            if (baruapdate)
            {
                for (int x = 0; x > 10; x++)
                {
                    barsI[i + x].BarTick();
                }
            }
        }
        internal static void ThreadE(int i)
        {
            if (baruapdate)
            {
                for (int x = 0; x > 10; x++)
                {
                    barsE[i + x].BarTick();
                }
            }
        }
        internal static void ThreadVH(int i)
        {
            if (baruapdate)
            {
                for (int x = 0; x > 10; x++)
                {
                    barsVH[i + x].BarTick();
                }
            }
        }
        internal static void ThreadH(int i)
        {
            if (baruapdate)
            {
                for (int x = 0; x > 10; x++)
                {
                    barsH[i + x].BarTick();
                }
            }
        }
        internal static void ThreadM(int i)
        {
            if (baruapdate)
            {
                for (int x = 0; x > 10; x++)
                {
                    barsM[i + x].BarTick();
                }
            }
        }
        internal static void ThreadN(int i)
        {
            if (baruapdate)
            {
                for (int x = 0; x>10;x++)
                {
                    barsN[i+x].BarTick();
                }
            }
        }
        internal static void ThreadManager()
        {

        }
    }
    internal struct BarNormal
    {
        internal BigInteger i;
        internal BigInteger BarTick()
        {
            if (i > 99)
            {
                i = 0;
                return Program.levelp * Program.level;
            }
            BigInteger written = 0;
            Console.Write("[");
            for (BigInteger y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (BigInteger y = (100 - written); y > 0; y--)
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
        internal BigInteger i;
        internal BigInteger BarTick()
        {
            if (i >= 150)
            {
                i = 0;
                return Program.levelp * Program.level;
            }
            BigInteger written = 0;
            Console.Write("[");
            for (BigInteger y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (BigInteger y = (150 - written); y > 0; y--)
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
        internal BigInteger i;
        internal BigInteger BarTick()
        {
            if (i >= 150)
            {
                i = 0;
                return (Program.levelp * Program.level * Program.resourceboost) / 2;
            }
            BigInteger written = 0;
            Console.Write("[");
            for (BigInteger y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (BigInteger y = (150 - written); y > 0; y--)
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
        internal BigInteger i;
        internal BigInteger BarTick()
        {
            if (i >= 250)
            {
                i = 0;
                return (Program.level * Program.resourceboost * Program.level) / 2;
            }
            BigInteger written = 0;
            Console.Write("[");
            for (BigInteger y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (BigInteger y = (250 - written); y > 0; y--)
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
        internal BigInteger i;
        internal BigInteger BarTick()
        {
            if (i >= 300)
            {
                i = 0;
                return (Program.levelp * Program.resourceboost * Program.level) / 4;
            }
            BigInteger written = 0;
            Console.Write("[");
            for (BigInteger y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (BigInteger y = (300 - written); y > 0; y--)
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
        internal BigInteger i;
        internal BigInteger BarTick()
        {
            if (i >= 500)
            {
                i = 0;
                return (Program.levelp * Program.resourceboost * Program.level) / 8;
            }
            BigInteger written = 0;
            Console.Write("[");
            for (BigInteger y = 0; y < i; y++)
            {
                Console.Write("=");
                written++;
            }
            for (BigInteger y = (500 - written); y > 0; y--)
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
