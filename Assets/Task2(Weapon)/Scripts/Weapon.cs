using Task2_Weapon_.Scripts.Models;
using UnityEngine;

namespace Task2_Weapon_.Scripts
{
    public class Weapon
    {
        private IShoot _shoot;
        private int _bulletsCount;
        private bool _isCageEndless;
        
        public Weapon(IShoot shoot, int bulletCount, bool isCageEndless, WeaponModel weaponModel)
        {
            _shoot = shoot;
            _bulletsCount = bulletCount;
            _isCageEndless = isCageEndless;
             WeaponModel = weaponModel.Init();
        }
        
        public WeaponModel WeaponModel { get; }

        public void Fire()
        {
            if (_shoot == null) return;
            
            _shoot.Shoot(WeaponModel.BulletSpawnPoint, WeaponModel.Bullet);
            
            if (_isCageEndless == false)
                _bulletsCount -= _shoot.BulletsPerShoot;
        }

        public bool CanShoot()
        {
            if (_bulletsCount > 0) return true;
            
            Debug.Log("Патроны закончились");
            return false;

        }
    }
}