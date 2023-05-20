using Dota2GSI;
using Dota2GSI.Nodes;
using System.Linq;

namespace DotaMatchMaster.Observer
{
    // Magnus empower yourself and carry
    internal class ItemCooldownObserver : IObserver
    {
        string _itemName;
        string _itemPrettyName;

        protected ItemCooldownObserver(string itemName)
        {
            _itemName = itemName;
            _itemPrettyName = _itemName.Replace('_', ' ');
        }

        protected override void HandleObservation(GameState gameState)
        {
            int index = gameState.Items.InventoryIndexOf(_itemName);

            Item item = null;

            if (index != -1)
            {
                item = gameState.Items.GetInventoryAt(index);
            }
            else
            {
                index = gameState.Items.StashIndexOf(_itemName);

                if (index != -1)
                {
                    item = gameState.Items.GetStashAt(index);
                }
            }

            if (item != null)
            {
                if (item.Cooldown == 1)
                {
                    GameManager.GetInstance().Notify($"Your {_itemPrettyName} is now available");
                }
            }
        }
    }
}
