using UnityEngine;

namespace Task3_Trade_.Scripts
{
    public class Trader: MonoBehaviour
    {
        [SerializeField] private int _buyerMinTradeReputation;
        [SerializeField] private int _buyerMaxFruitTradeReputation;
        
        private ITrade _trade;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IBuyer buyer))
            {
                MakeTradeDecision(buyer.Reputation);
                _trade?.Trade();
            }
        }

        private void MakeTradeDecision(int bayerReputation)
        {
            if (bayerReputation < _buyerMinTradeReputation)
            {
                _trade = new NoTradePattern();
            }
            
            if (bayerReputation > _buyerMinTradeReputation && bayerReputation <= _buyerMaxFruitTradeReputation)
            {
                _trade = new FruitTradePattern();
            }
            
            if (bayerReputation > _buyerMaxFruitTradeReputation)
            {
                _trade = new ArmorTradePattern();
            }
        }
    }
}