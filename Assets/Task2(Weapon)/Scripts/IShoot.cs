using Task2_Weapon_.Scripts.Models;
using UnityEngine;

namespace Task2_Weapon_.Scripts
{
    public interface IShoot
    {
        public int BulletsPerShoot { get; }
        
        void Shoot(Transform bulletSpawnPoint, Bullet bullet);
    }
}