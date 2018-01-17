using Levolution.Data.Timeline;
using System;
using System.Threading;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new ImmediateClock();
            var t = new IntegerTimeline()
            {
                From = 0,
                To = 100,
                Clock = clock,
                Duration = new Duration(TimeSpan.FromSeconds(5))
            };

            var startTime = DateTime.Now;
            t.Play();

            while(t.CurrentState == TimelineState.Playing)
            {
                clock.Update();
                Console.WriteLine(t.Value);
                Thread.Sleep(100);
            }
            Console.WriteLine($"Time: {(DateTime.Now - startTime).TotalMilliseconds}/ms");
        }
    }
}
