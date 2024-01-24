using UnityEngine;

namespace Task3_Trade_.Scripts
{
    public class NoTradePattern: ITrade
    {
        public void Trade()
        {
            Debug.Log("Я тебя не знаю, предложить для покупки нечего");
        }
    }
}