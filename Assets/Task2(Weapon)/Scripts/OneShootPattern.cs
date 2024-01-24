using Task2_Weapon_.Scripts.Models;
using UnityEngine;

namespace Task2_Weapon_.Scripts
{
    public class OneShootPattern : IShoot
    {
        public OneShootPattern(int bulletsPerShoot)
        {
            BulletsPerShoot = bulletsPerShoot;
        }

        public int BulletsPerShoot { get; }

        public void Shoot(Transform bulletSpawnPoint, Bullet bullet)
        {
            bullet.Init(bulletSpawnPoint);
        }
    }
}