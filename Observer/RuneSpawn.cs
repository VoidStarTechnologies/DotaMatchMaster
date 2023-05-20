using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    internal class RuneSpawn : IObserver
    {
        protected override void HandleObservation(GameState gameState)
        {
            Clock clock = new Clock(gameState.Map.ClockTime);

            if ((clock.Minutes > 4 && clock.Minutes < 20 && (clock.Minutes + 1 % 2) == 0) && clock.Seconds == 50)
            {
                GameManager.GetInstance().Notify("Rune in 10 seconds");
            }
        }
    }
}
