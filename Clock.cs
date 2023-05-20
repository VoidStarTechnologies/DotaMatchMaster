namespace DotaMatchMaster
{
    internal class Clock
    {
        public Clock(int clockTime)
        {
            Hours = clockTime / 3600;
            Minutes = (clockTime % 3600) / 60;
            Seconds = clockTime % 60;
        }

        public string Stringify()
        {
            return $"{Hours.ToString("00")}:{Minutes.ToString("00")}:{Seconds.ToString("00")}";
        }
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }
    }
}
