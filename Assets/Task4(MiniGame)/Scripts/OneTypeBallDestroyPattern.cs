using UnityEngine;

namespace Task4_MiniGame_.Scripts
{
    public class OneTypeBallDestroyPattern : IGame
    {
        public void GameOver()
        {
            Debug.Log("Game Over! Все шары одного типа уничтожены");
            Time.timeScale = 0;
        }
    }
}