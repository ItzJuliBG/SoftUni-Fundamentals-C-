using System;
using System.Threading;

public class Program
{
    static bool stopTimer = false;

    public static void Main()
    {
        Console.WriteLine("floor");
        int floor = int.Parse(Console.ReadLine());
        Console.WriteLine("ceiling");
        int ceiling = int.Parse(Console.ReadLine());
        Console.WriteLine("current");
        int current = int.Parse(Console.ReadLine());

        Timer timer = new Timer(TimerCallback, new TimerState(floor, ceiling, current), 0, 1000);

        Thread consoleThread = new Thread(ConsoleThread);
        consoleThread.Start();
        consoleThread.Join();
        timer.Dispose();

        Console.WriteLine("Pump stopped.");
        Console.ReadLine();
    }

    public class TimerState
    {
        public TimerState(int floor, int ceiling, int current)
        {
            Floor = floor;
            Ceiling = ceiling;
            Current = current;
        }

        public int Floor { get; set; }
        public int Ceiling { get; set; }
        public int Current { get; set; }
    }

    static void TimerCallback(object state)
    {
        TimerState timerState = (TimerState)state;
        int current = timerState.Current;
        int ceiling = timerState.Ceiling;
        int floor = timerState.Floor;

        if (current == ceiling)
        {
            while (current != floor)
            {
                timerState.Current--;
                current--;
                Thread.Sleep(1000);
                Console.WriteLine(current);
            }
        }
        else if (current == floor)
        {
            while (current != ceiling)
            {
                timerState.Current++;
                current++;
                Thread.Sleep(1000);
                Console.WriteLine(current);
            }
        }

        if (stopTimer)
        {
            Console.WriteLine("Pump stopped.");
        }
    }

    static void ConsoleThread()
    {
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "stop")
            {
                stopTimer = true;
                break;
            }
        }
    }
}
