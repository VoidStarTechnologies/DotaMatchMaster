using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    internal class TormentorSpawn : IObserver
    {
        protected override void HandleObservation(GameState gameState)
        {
            Clock clock = new Clock(gameState.Map.ClockTime);

            if (clock.Hours == 0 && clock.Minutes == 19 && clock.Seconds == 30)
            {
                GameManager.GetInstance().Notify("Tormentor in 30 seconds");
            }
        }
    }
}
