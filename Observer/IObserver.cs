using Dota2GSI;

namespace DotaMatchMaster.Observer
{
    abstract class IObserver
    {
        public virtual void Observe(GameState gameState)
        {
            try
            {
                if (gameState is null)
                {
                    return;
                }

                HandleObservation(gameState);
            }
            // @WORKAROUND
            // For some reason when dota is in transition between hero selection
            // and the game start, when trying to use any of the game state information
            // will throw the following exception:
            // System.ArgumentException: 'Valor 'DOTA_GAMERULES_STATE_TEAM_SHOWCASE' solicitado não foi encontrado.'
            catch (System.ArgumentException)
            {
            }

        }
        protected abstract void HandleObservation(GameState gameState);
    }
}
