namespace Smarta_Klockan
{
    internal class Program
    {
        public class SmartClock
        {
            public int Seconds { get; set; }

            public SmartClock(int hours, int minutes, int seconds)
            {
                this.Seconds = hours * 3600 + minutes * 60 + seconds;
            }

            public void Print()
            {
                int h = this.Seconds / 3600;
                if (h >= 24)
                {
                    h = 0 + h - 24;
                }

                int m = (this.Seconds % 3600) / 60;
                int s = this.Seconds % 60;
                Console.WriteLine($"{h}:{m}:{s}");
            }
            public void AddHours(int hours)
            {
                this.Seconds += hours * 3600;
            }
            public void AddMinutes(int minutes)
            {
                this.Seconds += minutes * 60;

            }
            public void AddClock(int hours, int minutes)
            {
                AddHours(hours);
                AddMinutes(minutes);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine();

            SmartClock sm = new SmartClock(20, 25, 13);
            sm.Print();
            sm.AddHours(7);
            sm.AddMinutes(36);
            sm.Print();
        }
    }
}