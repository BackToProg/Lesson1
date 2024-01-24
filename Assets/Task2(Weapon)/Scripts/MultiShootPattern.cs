using Task2_Weapon_.Scripts.Models;
using UnityEngine;

namespace Task2_Weapon_.Scripts
{
    public class MultiShootPattern: IShoot
    {
        public MultiShootPattern(int bulletsPerShoot)
        {
            BulletsPerShoot = bulletsPerShoot;
        }

        public int BulletsPerShoot { get; }
        
        public void Shoot(Transform bulletSpawnPoint, Bullet bullet)
        {
            Vector3 offsetValue = new Vector3(0.4f, 0, 0);
            
            for (int i = 0; i < BulletsPerShoot; i++)
            {
                bullet.Init(bulletSpawnPoint);
                bulletSpawnPoint.position += offsetValue;
            }
        }
    }
}