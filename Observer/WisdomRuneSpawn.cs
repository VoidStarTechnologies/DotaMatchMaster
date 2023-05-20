using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    internal class WisdomRuneSpawn : IObserver
    {
        protected override void HandleObservation(GameState gameState)
        {
            Clock clock = new Clock(gameState.Map.ClockTime);

            if ((clock.Minutes + 1) % 7 == 0 && clock.Seconds == 30)
            {
                GameManager.GetInstance().Notify("Wisdom rune in 30 seconds");
            }
        }
    }
}
