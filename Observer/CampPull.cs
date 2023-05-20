using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    internal class CampPull : IObserver
    {
        protected override void HandleObservation(GameState gameState)
        {
            Clock clock = new Clock(gameState.Map.ClockTime);

            int offset = 0;

            if (!gameState.Map.IsDaytime)
            {
                offset = -5;
            }

            if (clock.Hours == 0 && clock.Minutes >= 1 && clock.Minutes <= 10 && clock.Seconds == 10 + offset)
            {
                GameManager.GetInstance().Notify("Pull camp in 10 seconds");
            }
        }
    }
}
