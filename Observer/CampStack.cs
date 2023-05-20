using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    internal class CampStack : IObserver
    {
        protected override void HandleObservation(GameState gameState)
        {
            Clock clock = new Clock(gameState.Map.ClockTime);

            if (clock.Hours == 0 && clock.Minutes >= 1 && clock.Minutes <= 30 && clock.Seconds == 35)
            {
                GameManager.GetInstance().Notify("Stack camp in 10 seconds");
            }
        }
    }
}
