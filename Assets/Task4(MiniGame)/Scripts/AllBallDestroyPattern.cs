using UnityEngine;

namespace Task4_MiniGame_.Scripts
{
    public class AllBallDestroyPattern: IGame
    {
        public void GameOver()
        {
            Debug.Log("Game Over! Шары одного цвета уничтожены");
            Time.timeScale = 0;
        }
    }
}