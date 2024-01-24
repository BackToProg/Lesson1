using UnityEngine;

namespace Task3_Trade_.Scripts
{
    public class FruitTradePattern: ITrade
    {
        public void Trade()
        {
            Debug.Log("При твоей репутации могу предложить к покупке фрукты");
        }
    }
}