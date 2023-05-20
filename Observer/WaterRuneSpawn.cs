using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    internal class WaterRuneSpawn : IObserver
    {
        protected override void HandleObservation(GameState gameState)
        {
            Clock clock = new Clock(gameState.Map.ClockTime);

            if (clock.Hours == 0 && (clock.Minutes == 1 || clock.Minutes == 3) && clock.Seconds == 50)
            {
                GameManager.GetInstance().Notify("Water rune in 10 seconds");
            }
        }
    }
}
