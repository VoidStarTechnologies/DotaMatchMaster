using Dota2GSI;
using Dota2GSI.Nodes;

namespace DotaMatchMaster.Observer
{
    internal class BuybackCooldown : IObserver
    {
        protected override void HandleObservation(GameState gameState)
        {
            if (gameState.Hero.BuybackCooldown == 1)
            {
                GameManager.GetInstance().Notify("Your buyback is now off cooldown");
            }
        }
    }
}
