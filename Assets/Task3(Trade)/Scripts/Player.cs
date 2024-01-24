using UnityEngine;

namespace Task3_Trade_.Scripts
{
    public class Player: MonoBehaviour, IBuyer
    {
        [SerializeField] private int _reputation;

        public int Reputation => _reputation;
    }
}