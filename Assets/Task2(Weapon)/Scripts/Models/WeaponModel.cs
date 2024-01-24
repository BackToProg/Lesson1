using UnityEngine;

namespace Task2_Weapon_.Scripts.Models
{
    public abstract class WeaponModel : MonoBehaviour
    {
        [SerializeField] private WeaponModel _weaponTemplate;
        [SerializeField] private Transform _bulletSpawnPoint;
        [SerializeField] private Bullet _bullet;
        
        public WeaponModel Init()
        {
            return Instantiate(_weaponTemplate, Vector3.zero, Quaternion.identity);
        }
        
        public Transform BulletSpawnPoint => _bulletSpawnPoint;
        public Bullet Bullet => _bullet;
        
        public void Activate() => gameObject.SetActive(true);
        public void Deactivate() => gameObject.SetActive(false);
    }
}