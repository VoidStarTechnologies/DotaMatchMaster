using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    internal class TokenAvailability : IObserver
    {
        static readonly int[] _tokenTimes = { 7, 17, 27, 37, 60 };
        protected override void HandleObservation(GameState gameState)
        {
            Clock clock = new Clock(gameState.Map.ClockTime);

            for (int index = 0; index < _tokenTimes.Length; index++)
            {
                if (clock.Hours == 0 && clock.Minutes == _tokenTimes[index] && clock.Seconds == 0)
                {
                    GameManager.GetInstance().Notify($"Token tier {index + 1} is now available");
                }
            }
        }
    }
}
