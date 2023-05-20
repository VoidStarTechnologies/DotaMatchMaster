using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    internal class BountyRuneSpawn : IObserver
    {
        protected override void HandleObservation(GameState gameState)
        {
            Clock clock = new Clock(gameState.Map.ClockTime);

            if (clock.Minutes > 1 && clock.Minutes % 3 == 0 && clock.Seconds == 0)
            {
                GameManager.GetInstance().Notify("Bounty rune spawned");
            }
        }
    }
}
