using UnityEngine;

namespace Task4_MiniGame_.Scripts.Models
{
    public class Ball : MonoBehaviour, IBall
    {
        public void Destroy()
        {
            Destroy(gameObject);
        }
    }
}