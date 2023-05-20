using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    internal class HealingLotusSpawn : IObserver
    {
        protected override void HandleObservation(GameState gameState)
        {
            Clock clock = new Clock(gameState.Map.ClockTime);

            if ((clock.Minutes + 1) % 3 == 0 && clock.Seconds == 50)
            {
                GameManager.GetInstance().Notify("Healing lotus in 10 seconds");
            }
        }
    }
}
