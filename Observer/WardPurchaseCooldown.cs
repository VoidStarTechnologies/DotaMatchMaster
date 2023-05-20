using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    internal class WardPurchaseCooldown : IObserver
    {
        protected override void HandleObservation(GameState gameState)
        {
            if (gameState.Map.Ward_Purchase_Cooldown == 1)
            {
                GameManager.GetInstance().Notify("Ward purchase is off cooldown");
            }
        }
    }
}
