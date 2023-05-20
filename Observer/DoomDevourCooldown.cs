using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    internal class DoomDevourCooldown : IObserver
    {
        protected override void HandleObservation(GameState gameState)
        {
            if (gameState.Hero.ID != 69)
            {
                return;
            } 

            if (gameState.Abilities[0].Cooldown == 1)
            {
                GameManager.GetInstance().Notify("Devour is now available");
            }

        }
    }
}
