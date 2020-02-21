using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ed's awesome stop watch app!");
            
            bool quit = false;
            while (!quit)
            {
                Console.Write("\nType \"S\" to start the stopwatch or \"Q\" to quit: ");
                string user_input = Console.ReadLine().ToLower();
                if (user_input == "q")
                {
                    quit = true;
                }

                if (user_input == "s")
                {
                    var timer = new StopWatch();
                    Console.Write("\nHit enter to stop the timer.");
                    Console.ReadLine();
                    timer.Stop();
                    Console.WriteLine("\nThe total time was " + timer.duration());
                }
            }
            Console.WriteLine("\nGoodbye...");
        }
    }

    public class StopWatch
    {
        public DateTime TimerStart { get; set; }
        public DateTime TimerStop;
        public StopWatch()
        {
            this.TimerStart = DateTime.Now;
            Console.WriteLine("\nTimer started at: " + TimerStart);
        }

        public void Stop()
        {
            this.TimerStop = DateTime.Now;
            Console.WriteLine("\nTimer stoped at: " + TimerStop);
        }

        public TimeSpan duration()
        {
            return (TimerStop - TimerStart);
        }
    }
}
