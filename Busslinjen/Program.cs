using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Busslinjen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var busStop = new List<Passenger>();
            var bus = new List<Passenger>();
            int busMaxCapacity = 81;
            int busCurrentPassengers = 0;
            int CurrentArea = 1;

            bool rushhour = StartingMeny();


            while (true)
            {
                int waiting;
                if (rushhour) { waiting = 150 + 1; }
                else { waiting = 40 + 1; }

                Console.WriteLine(" Rushhour: " + rushhour);
                Console.WriteLine($" Bus maximum passenger capacity: {busMaxCapacity}");
                Console.WriteLine();

                var Events = new List<string>();
                int enter = 0;
                int exit = 0;

                for (int i = 0; i < rnd.Next(1, waiting); i++)
                {
                    busStop.Add(new Passenger(rnd.Next(1, 10 + 1), rnd.Next(1, 10 + 1)));
                }

                DrawBus(CurrentArea);
                Console.WriteLine();
                DrawBusStops();
                Console.ForegroundColor = ConsoleColor.Yellow;
                DrawPassengers(busStop);
                Console.ForegroundColor = ConsoleColor.White;

                switch (CurrentArea)
                {
                    case 1:

                        foreach (Passenger p in bus)
                        {
                            if ((p.ExitBusStop) == CurrentArea)
                            {
                                exit++;
                            }
                        }

                        if (exit > 0) { Events.Add($" {exit} passengers exited the bus at H{CurrentArea - 1}"); }

                        bus.RemoveAll(bus => bus.ExitBusStop == CurrentArea);
                        busCurrentPassengers = bus.Count;

                        if (busCurrentPassengers <= busMaxCapacity)
                        {
                            foreach (Passenger p in busStop)
                            {
                                if ((p.StartingBusStop) == CurrentArea)
                                {
                                    enter++;
                                }
                            }

                            if (enter > 0) { Events.Add($" {enter} passengers entered the bus at H{CurrentArea - 1}. "); }

                            var GettingOn = busStop.Where(busStop => busStop.StartingBusStop == CurrentArea).ToList();
                            busStop = busStop.Except(GettingOn).ToList();
                            bus.AddRange(GettingOn);

                            busCurrentPassengers = bus.Count;

                            if (busCurrentPassengers > busMaxCapacity)
                            {
                                
                                int removeExcess = busCurrentPassengers % busMaxCapacity;
                                int removed = removeExcess;
                                for (int i = 0; i < removeExcess; i++)
                                {
                                    bus.RemoveAt(busMaxCapacity + removed - 1);
                                    busStop.Add(new Passenger(CurrentArea, rnd.Next(1, 10 + 1)));
                                    removed--;
                                }
                                Events.Add($"The bus was full and {removeExcess} had to get off before the bus left.");
                                
                            }
                        }

                        CurrentArea++;
                        break;
                    case 2:

                        foreach (Passenger p in bus)
                        {
                            if ((p.ExitBusStop) == CurrentArea)
                            {
                                exit++;
                            }
                        }

                        if (exit > 0) { Events.Add($" {exit} passengers exited the bus at H{CurrentArea - 1}"); }

                        bus.RemoveAll(bus => bus.ExitBusStop == CurrentArea);
                        busCurrentPassengers = bus.Count;

                        if (busCurrentPassengers <= busMaxCapacity)
                        {
                            foreach (Passenger p in busStop)
                            {
                                if ((p.StartingBusStop) == CurrentArea)
                                {
                                    enter++;
                                }
                            }

                            if (enter > 0) { Events.Add($" {enter} passengers entered the bus at H{CurrentArea - 1}. "); }

                            var GettingOn = busStop.Where(busStop => busStop.StartingBusStop == CurrentArea).ToList();
                            busStop = busStop.Except(GettingOn).ToList();
                            bus.AddRange(GettingOn);

                            busCurrentPassengers = bus.Count;

                            if (busCurrentPassengers > busMaxCapacity)
                            {

                                int removeExcess = busCurrentPassengers % busMaxCapacity;
                                int removed = removeExcess;
                                for (int i = 0; i < removeExcess; i++)
                                {
                                    bus.RemoveAt(busMaxCapacity + removed - 1);
                                    busStop.Add(new Passenger(CurrentArea, rnd.Next(1, 10 + 1)));
                                    removed--;
                                }
                                Events.Add($"The bus was full and {removeExcess} had to get off before the bus left.");

                            }
                        }

                        CurrentArea++;
                        break;
                    case 3:

                        foreach (Passenger p in bus)
                        {
                            if ((p.ExitBusStop) == CurrentArea)
                            {
                                exit++;
                            }
                        }

                        if (exit > 0) { Events.Add($" {exit} passengers exited the bus at H{CurrentArea - 1}"); }

                        bus.RemoveAll(bus => bus.ExitBusStop == CurrentArea);
                        busCurrentPassengers = bus.Count;

                        if (busCurrentPassengers <= busMaxCapacity)
                        {
                            foreach (Passenger p in busStop)
                            {
                                if ((p.StartingBusStop) == CurrentArea)
                                {
                                    enter++;
                                }
                            }

                            if (enter > 0) { Events.Add($" {enter} passengers entered the bus at H{CurrentArea - 1}. "); }

                            var GettingOn = busStop.Where(busStop => busStop.StartingBusStop == CurrentArea).ToList();
                            busStop = busStop.Except(GettingOn).ToList();
                            bus.AddRange(GettingOn);

                            busCurrentPassengers = bus.Count;

                            if (busCurrentPassengers > busMaxCapacity)
                            {

                                int removeExcess = busCurrentPassengers % busMaxCapacity;
                                int removed = removeExcess;
                                for (int i = 0; i < removeExcess; i++)
                                {
                                    bus.RemoveAt(busMaxCapacity + removed - 1);
                                    busStop.Add(new Passenger(CurrentArea, rnd.Next(1, 10 + 1)));
                                    removed--;
                                }
                                Events.Add($"The bus was full and {removeExcess} had to get off before the bus left.");

                            }
                        }

                        CurrentArea++;
                        break;
                    case 4:

                        foreach (Passenger p in bus)
                        {
                            if ((p.ExitBusStop) == CurrentArea)
                            {
                                exit++;
                            }
                        }

                        if (exit > 0) { Events.Add($" {exit} passengers exited the bus at H{CurrentArea - 1}"); }

                        bus.RemoveAll(bus => bus.ExitBusStop == CurrentArea);
                        busCurrentPassengers = bus.Count;

                        if (busCurrentPassengers <= busMaxCapacity)
                        {
                            foreach (Passenger p in busStop)
                            {
                                if ((p.StartingBusStop) == CurrentArea)
                                {
                                    enter++;
                                }
                            }

                            if (enter > 0) { Events.Add($" {enter} passengers entered the bus at H{CurrentArea - 1}. "); }

                            var GettingOn = busStop.Where(busStop => busStop.StartingBusStop == CurrentArea).ToList();
                            busStop = busStop.Except(GettingOn).ToList();
                            bus.AddRange(GettingOn);

                            busCurrentPassengers = bus.Count;

                            if (busCurrentPassengers > busMaxCapacity)
                            {

                                int removeExcess = busCurrentPassengers % busMaxCapacity;
                                int removed = removeExcess;
                                for (int i = 0; i < removeExcess; i++)
                                {
                                    bus.RemoveAt(busMaxCapacity + removed - 1);
                                    busStop.Add(new Passenger(CurrentArea, rnd.Next(1, 10 + 1)));
                                    removed--;
                                }
                                Events.Add($"The bus was full and {removeExcess} had to get off before the bus left.");

                            }
                        }

                        CurrentArea++;
                        break;
                    case 5:

                        foreach (Passenger p in bus)
                        {
                            if ((p.ExitBusStop) == CurrentArea)
                            {
                                exit++;
                            }
                        }

                        if (exit > 0) { Events.Add($" {exit} passengers exited the bus at H{CurrentArea - 1}"); }

                        bus.RemoveAll(bus => bus.ExitBusStop == CurrentArea);
                        busCurrentPassengers = bus.Count;

                        if (busCurrentPassengers <= busMaxCapacity)
                        {
                            foreach (Passenger p in busStop)
                            {
                                if ((p.StartingBusStop) == CurrentArea)
                                {
                                    enter++;
                                }
                            }

                            if (enter > 0) { Events.Add($" {enter} passengers entered the bus at H{CurrentArea - 1}. "); }

                            var GettingOn = busStop.Where(busStop => busStop.StartingBusStop == CurrentArea).ToList();
                            busStop = busStop.Except(GettingOn).ToList();
                            bus.AddRange(GettingOn);

                            busCurrentPassengers = bus.Count;

                            if (busCurrentPassengers > busMaxCapacity)
                            {

                                int removeExcess = busCurrentPassengers % busMaxCapacity;
                                int removed = removeExcess;
                                for (int i = 0; i < removeExcess; i++)
                                {
                                    bus.RemoveAt(busMaxCapacity + removed - 1);
                                    busStop.Add(new Passenger(CurrentArea, rnd.Next(1, 10 + 1)));
                                    removed--;
                                }
                                Events.Add($"The bus was full and {removeExcess} had to get off before the bus left.");

                            }
                        }

                        CurrentArea++;
                        break;
                    case 6:

                        foreach (Passenger p in bus)
                        {
                            if ((p.ExitBusStop) == CurrentArea)
                            {
                                exit++;
                            }
                        }

                        if (exit > 0) { Events.Add($" {exit} passengers exited the bus at H{CurrentArea - 1}"); }

                        bus.RemoveAll(bus => bus.ExitBusStop == CurrentArea);
                        busCurrentPassengers = bus.Count;

                        if (busCurrentPassengers <= busMaxCapacity)
                        {
                            foreach (Passenger p in busStop)
                            {
                                if ((p.StartingBusStop) == CurrentArea)
                                {
                                    enter++;
                                }
                            }

                            if (enter > 0) { Events.Add($" {enter} passengers entered the bus at H{CurrentArea - 1}. "); }

                            var GettingOn = busStop.Where(busStop => busStop.StartingBusStop == CurrentArea).ToList();
                            busStop = busStop.Except(GettingOn).ToList();
                            bus.AddRange(GettingOn);

                            busCurrentPassengers = bus.Count;

                            if (busCurrentPassengers > busMaxCapacity)
                            {

                                int removeExcess = busCurrentPassengers % busMaxCapacity;
                                int removed = removeExcess;
                                for (int i = 0; i < removeExcess; i++)
                                {
                                    bus.RemoveAt(busMaxCapacity + removed - 1);
                                    busStop.Add(new Passenger(CurrentArea, rnd.Next(1, 10 + 1)));
                                    removed--;
                                }
                                Events.Add($"The bus was full and {removeExcess} had to get off before the bus left.");

                            }
                        }

                        CurrentArea++;
                        break;

                    case 7:

                        foreach (Passenger p in bus)
                        {
                            if ((p.ExitBusStop) == CurrentArea)
                            {
                                exit++;
                            }
                        }

                        if (exit > 0) { Events.Add($" {exit} passengers exited the bus at H{CurrentArea - 1}"); }

                        bus.RemoveAll(bus => bus.ExitBusStop == CurrentArea);
                        busCurrentPassengers = bus.Count;

                        if (busCurrentPassengers <= busMaxCapacity)
                        {
                            foreach (Passenger p in busStop)
                            {
                                if ((p.StartingBusStop) == CurrentArea)
                                {
                                    enter++;
                                }
                            }

                            if (enter > 0) { Events.Add($" {enter} passengers entered the bus at H{CurrentArea - 1}. "); }

                            var GettingOn = busStop.Where(busStop => busStop.StartingBusStop == CurrentArea).ToList();
                            busStop = busStop.Except(GettingOn).ToList();
                            bus.AddRange(GettingOn);

                            busCurrentPassengers = bus.Count;

                            if (busCurrentPassengers > busMaxCapacity)
                            {

                                int removeExcess = busCurrentPassengers % busMaxCapacity;
                                int removed = removeExcess;
                                for (int i = 0; i < removeExcess; i++)
                                {
                                    bus.RemoveAt(busMaxCapacity + removed - 1);
                                    busStop.Add(new Passenger(CurrentArea, rnd.Next(1, 10 + 1)));
                                    removed--;
                                }
                                Events.Add($"The bus was full and {removeExcess} had to get off before the bus left.");

                            }
                        }

                        CurrentArea++;
                        break;
                    case 8:

                        foreach (Passenger p in bus)
                        {
                            if ((p.ExitBusStop) == CurrentArea)
                            {
                                exit++;
                            }
                        }

                        if (exit > 0) { Events.Add($" {exit} passengers exited the bus at H{CurrentArea - 1}"); }

                        bus.RemoveAll(bus => bus.ExitBusStop == CurrentArea);
                        busCurrentPassengers = bus.Count;

                        if (busCurrentPassengers <= busMaxCapacity)
                        {
                            foreach (Passenger p in busStop)
                            {
                                if ((p.StartingBusStop) == CurrentArea)
                                {
                                    enter++;
                                }
                            }

                            if (enter > 0) { Events.Add($" {enter} passengers entered the bus at H{CurrentArea - 1}. "); }

                            var GettingOn = busStop.Where(busStop => busStop.StartingBusStop == CurrentArea).ToList();
                            busStop = busStop.Except(GettingOn).ToList();
                            bus.AddRange(GettingOn);

                            busCurrentPassengers = bus.Count;

                            if (busCurrentPassengers > busMaxCapacity)
                            {

                                int removeExcess = busCurrentPassengers % busMaxCapacity;
                                int removed = removeExcess;
                                for (int i = 0; i < removeExcess; i++)
                                {
                                    bus.RemoveAt(busMaxCapacity + removed - 1);
                                    busStop.Add(new Passenger(CurrentArea, rnd.Next(1, 10 + 1)));
                                    removed--;
                                }
                                Events.Add($"The bus was full and {removeExcess} had to get off before the bus left.");

                            }
                        }

                        CurrentArea++;
                        break;
                    case 9:

                        foreach (Passenger p in bus)
                        {
                            if ((p.ExitBusStop) == CurrentArea)
                            {
                                exit++;
                            }
                        }

                        if (exit > 0) { Events.Add($" {exit} passengers exited the bus at H{CurrentArea - 1}"); }

                        bus.RemoveAll(bus => bus.ExitBusStop == CurrentArea);
                        busCurrentPassengers = bus.Count;

                        if (busCurrentPassengers <= busMaxCapacity)
                        {
                            foreach (Passenger p in busStop)
                            {
                                if ((p.StartingBusStop) == CurrentArea)
                                {
                                    enter++;
                                }
                            }

                            if (enter > 0) { Events.Add($" {enter} passengers entered the bus at H{CurrentArea - 1}. "); }

                            var GettingOn = busStop.Where(busStop => busStop.StartingBusStop == CurrentArea).ToList();
                            busStop = busStop.Except(GettingOn).ToList();
                            bus.AddRange(GettingOn);

                            busCurrentPassengers = bus.Count;

                            if (busCurrentPassengers > busMaxCapacity)
                            {

                                int removeExcess = busCurrentPassengers % busMaxCapacity;
                                int removed = removeExcess;
                                for (int i = 0; i < removeExcess; i++)
                                {
                                    bus.RemoveAt(busMaxCapacity + removed - 1);
                                    busStop.Add(new Passenger(CurrentArea, rnd.Next(1, 10 + 1)));
                                    removed--;
                                }
                                Events.Add($"The bus was full and {removeExcess} had to get off before the bus left.");

                            }
                        }

                        CurrentArea++;
                        break;
                    case 10:

                        foreach (Passenger p in bus)
                        {
                            if ((p.ExitBusStop) == CurrentArea)
                            {
                                exit++;
                            }
                        }

                        if (exit > 0) { Events.Add($" {exit} passengers exited the bus at H{CurrentArea - 1}"); }

                        bus.RemoveAll(bus => bus.ExitBusStop == CurrentArea);
                        busCurrentPassengers = bus.Count;

                        if (busCurrentPassengers <= busMaxCapacity)
                        {
                            foreach (Passenger p in busStop)
                            {
                                if ((p.StartingBusStop) == CurrentArea)
                                {
                                    enter++;
                                }
                            }

                            if (enter > 0) { Events.Add($" {enter} passengers entered the bus at H{CurrentArea - 1}. "); }

                            var GettingOn = busStop.Where(busStop => busStop.StartingBusStop == CurrentArea).ToList();
                            busStop = busStop.Except(GettingOn).ToList();
                            bus.AddRange(GettingOn);

                            busCurrentPassengers = bus.Count;

                            if (busCurrentPassengers > busMaxCapacity)
                            {

                                int removeExcess = busCurrentPassengers % busMaxCapacity;
                                int removed = removeExcess;
                                for (int i = 0; i < removeExcess; i++)
                                {
                                    bus.RemoveAt(busMaxCapacity + removed - 1);
                                    busStop.Add(new Passenger(CurrentArea, rnd.Next(1, 10 + 1)));
                                    removed--;
                                }
                                Events.Add($"The bus was full and {removeExcess} had to get off before the bus left.");

                            }
                        }

                        CurrentArea = 1;
                        break;
                }
            

                Console.WriteLine();
                Console.WriteLine();
                foreach (var word in Events)
                {
                    Console.WriteLine(word);
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($" Passengers riding the bus: {bus.Count}");
                Thread.Sleep(1800);
                Console.Clear();
            }
        }
        public static void DrawBus(int currentArea)
        {
            string space = "                "; //15
            
            for (int i = 1; i < currentArea; i++)
            {
                Console.Write(space);
            }
            Console.WriteLine("     _____________");
            for (int i = 1; i < currentArea; i++)
            {
                Console.Write(space);
            }
            Console.WriteLine("    |[][][][][][] |_");
            for (int i = 1; i < currentArea; i++)
            {
                Console.Write(space);
            }
            Console.WriteLine("    | City bus      )");
            for (int i = 1; i < currentArea; i++)
            {
                Console.Write(space);
            }
            Console.WriteLine("    =--OO-------OO--=");
        }
        public static void DrawBusStops()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("          ");
                Console.Write(" ____ ");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("          ");
                Console.Write($"|_H{i}_|");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("          ");
                Console.Write("  ||  ");
            }
            Console.WriteLine();
        }
        public static void DrawPassengers(List<Passenger> busStop)
        {
            string space = "             ";//13
            int AmountBusStop1 = 0;
            int AmountBusStop2 = 0;
            int AmountBusStop3 = 0;
            int AmountBusStop4 = 0;
            int AmountBusStop5 = 0;
            int AmountBusStop6 = 0;
            int AmountBusStop7 = 0;
            int AmountBusStop8 = 0;
            int AmountBusStop9 = 0;
            int AmountBusStop10 = 0;

            foreach (Passenger p in busStop)
            {
                switch (p.StartingBusStop)
                {
                    case 1:
                        AmountBusStop1++;
                        break;
                    case 2:
                        AmountBusStop2++;
                        break;
                    case 3:
                        AmountBusStop3++;
                        break;
                    case 4:
                        AmountBusStop4++;
                        break;
                    case 5:
                        AmountBusStop5++;
                        break;
                    case 6:
                        AmountBusStop6++;
                        break;
                    case 7:
                        AmountBusStop7++;
                        break;
                    case 8:
                        AmountBusStop8++;
                        break;
                    case 9:
                        AmountBusStop9++;
                        break;
                    case 10:
                        AmountBusStop10++;
                        break;
                }
            }

            int size = (AmountBusStop1 + AmountBusStop2 + AmountBusStop3 + AmountBusStop4 + AmountBusStop5 + AmountBusStop6 + AmountBusStop7 + AmountBusStop8 + AmountBusStop9 + AmountBusStop10) / 3;

            for (int y = 1; y <= size; y++)
            {
                while ((AmountBusStop1 + AmountBusStop2 + AmountBusStop3 + AmountBusStop4 + AmountBusStop5 + AmountBusStop6 + AmountBusStop7 + AmountBusStop8 + AmountBusStop9 + AmountBusStop10) > 0)
                {
                    Console.Write(space);
                    for (int i = 0; i < 3; i++)
                    {
                        if (AmountBusStop1 >= i && AmountBusStop1 != 0)
                        {
                            Console.Write("X");
                            AmountBusStop1--;
                        }
                        else { Console.Write(" "); }
                    }
                    Console.Write(space);
                    for (int i = 0; i < 3; i++)
                    {
                        if (AmountBusStop2 >= i && AmountBusStop2 != 0)
                        {
                            Console.Write("X");
                            AmountBusStop2--;
                        }
                        else { Console.Write(" "); }
                    }
                    Console.Write(space);
                    for (int i = 0; i < 3; i++)
                    {
                        if (AmountBusStop3 >= i && AmountBusStop3 != 0)
                        {
                            Console.Write("X");
                            AmountBusStop3--;
                        }
                        else { Console.Write(" "); }
                    }
                    Console.Write(space);
                    for (int i = 0; i < 3; i++)
                    {
                        if (AmountBusStop4 >= i && AmountBusStop4 != 0)
                        {
                            Console.Write("X");
                            AmountBusStop4--;
                        }
                        else { Console.Write(" "); }
                    }
                    Console.Write(space);
                    for (int i = 0; i < 3; i++)
                    {
                        if (AmountBusStop5 >= i && AmountBusStop5 != 0)
                        {
                            Console.Write("X");
                            AmountBusStop5--;
                        }
                        else { Console.Write(" "); }
                    }
                    Console.Write(space);
                    for (int i = 0; i < 3; i++)
                    {
                        if (AmountBusStop6 >= i && AmountBusStop6 != 0)
                        {
                            Console.Write("X");
                            AmountBusStop6--;
                        }
                        else { Console.Write(" "); }
                    }
                    Console.Write(space);
                    for (int i = 0; i < 3; i++)
                    {
                        if (AmountBusStop7 >= i && AmountBusStop7 != 0)
                        {
                            Console.Write("X");
                            AmountBusStop7--;
                        }
                        else { Console.Write(" "); }
                    }
                    Console.Write(space);
                    for (int i = 0; i < 3; i++)
                    {
                        if (AmountBusStop8 >= i && AmountBusStop8 != 0)
                        {
                            Console.Write("X");
                            AmountBusStop8--;
                        }
                        else { Console.Write(" "); }
                    }
                    Console.Write(space);
                    for (int i = 0; i < 3; i++)
                    {
                        if (AmountBusStop9 >= i && AmountBusStop9 != 0)
                        {
                            Console.Write("X");
                            AmountBusStop9--;
                        }
                        else { Console.Write(" "); }
                    }
                    Console.Write(space);
                    for (int i = 0; i < 3; i++)
                    {
                        if (AmountBusStop10 >= i && AmountBusStop10 != 0)
                        {
                            Console.Write("X");
                            AmountBusStop10--;
                        }
                        else { Console.Write(" "); }
                    }
                    Console.WriteLine();

                }
            }
        }
        public static bool StartingMeny()
        {
            bool rushhour = false;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@" __    __    ___  _        __   ___   ___ ___    ___                 ");
            Console.WriteLine(@"|  |__|  |  /  _]| |      /  ] /   \ |   |   |  /  _]                ");
            Console.WriteLine(@"|  |  |  | /  [_ | |     /  / |     || _   _ | /  [_                 ");
            Console.WriteLine(@"|  |  |  ||    _]| |___ /  /  |  O  ||  \_/  ||    _]                ");
            Console.WriteLine(@"|  `  '  ||   [_ |     /   \_ |     ||   |   ||   [_                 ");
            Console.WriteLine(@" \      / |     ||     \     ||     ||   |   ||     |                ");
            Console.WriteLine(@"  \_/\_/  |_____||_____|\____| \___/ |___|___||_____|                ");
            Console.WriteLine(@"                                                                     ");
            Console.WriteLine(@" ______   ___       ______  __ __    ___      ____   __ __  _____    ");
            Console.WriteLine(@"|      | /   \     |      ||  |  |  /  _]    |    \ |  |  |/ ___/    ");
            Console.WriteLine(@"|      ||     |    |      ||  |  | /  [_     |  o  )|  |  (   \_     ");
            Console.WriteLine(@"|_|  |_||  O  |    |_|  |_||  _  ||    _]    |     ||  |  |\__  |    ");
            Console.WriteLine(@"  |  |  |     |      |  |  |  |  ||   [_     |  O  ||  :  |/  \ |    ");
            Console.WriteLine(@"  |  |  |     |      |  |  |  |  ||     |    |     ||     |\    |    ");
            Console.WriteLine(@"  |__|   \___/       |__|  |__|__||_____|    |_____| \__,_| \___|    ");
            Console.WriteLine(@"                                                                     ");
            Console.WriteLine(@"  _____ ____  ___ ___  __ __  _       ____  ______   ___   ____   __ ");
            Console.WriteLine(@" / ___/|    ||   |   ||  |  || |     /    ||      | /   \ |    \ |  |");
            Console.WriteLine(@"(   \_  |  | | _   _ ||  |  || |    |  o  ||      ||     ||  D  )|  |");
            Console.WriteLine(@" \__  | |  | |  \_/  ||  |  || |___ |     ||_|  |_||  O  ||    / |__|");
            Console.WriteLine(@" /  \ | |  | |   |   ||  :  ||     ||  _  |  |  |  |     ||    \  __ ");
            Console.WriteLine(@" \    | |  | |   |   ||     ||     ||  |  |  |  |  |     ||  .  \|  |");
            Console.WriteLine(@"  \___||____||___|___| \__,_||_____||__|__|  |__|   \___/ |__|\_||__|");
            Console.WriteLine(@"                                                                     ");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      Press R for RushHour Simluation, otherwise any key:");

            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.R:
                    rushhour = true;
                    break;
                default:
                    break;
            }

            Console.Clear();
            return rushhour;

        }
    }
    public class Passenger
    {
        public int StartingBusStop;
        public int ExitBusStop;

        public Passenger(int rnd, int rnd2)
        {
            StartingBusStop = rnd;
            ExitBusStop = rnd2;
        }

    }
}
