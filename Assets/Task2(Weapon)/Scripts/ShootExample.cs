using Task2_Weapon_.Scripts.Models;
using UnityEngine;

namespace Task2_Weapon_.Scripts
{
    public class ShootExample : MonoBehaviour
    {
        [SerializeField] private OneShootWeapon _oneShootWeaponTemplate;
        [SerializeField] private OneShootWeaponUnlim _oneShootWeaponUnlimTemplate;
        [SerializeField] private MultiShootWeapon _multiShootWeaponTemplate;

        private Weapon _currentWeapon;
        private Weapon _oneShootWeapon;
        private Weapon _oneShootWeaponUnlimBullets;
        private Weapon _multiShootWeapon;

        private void Awake()
        {
            CreateWeapons();
            _currentWeapon = _oneShootWeapon;
            ActivateOneShootWeapon();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W) && _currentWeapon.CanShoot())
            {
                _currentWeapon.Fire();
            }

            SwitchWeapon();
        }

        private void SwitchWeapon()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _currentWeapon = _oneShootWeapon;
                ActivateOneShootWeapon();
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _currentWeapon = _oneShootWeaponUnlimBullets;
                ActivateOneShootWeaponUnlim();
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _currentWeapon = _multiShootWeapon;
                ActivateMiltyShootWeapon();
            }
        }

        private void ActivateMiltyShootWeapon()
        {
            _multiShootWeapon.WeaponModel.Activate();
            _oneShootWeaponUnlimBullets.WeaponModel.Deactivate();
            _oneShootWeapon.WeaponModel.Deactivate();
        }

        private void ActivateOneShootWeaponUnlim()
        {
            _oneShootWeaponUnlimBullets.WeaponModel.Activate();
            _multiShootWeapon.WeaponModel.Deactivate();
            _oneShootWeapon.WeaponModel.Deactivate();
        }

        private void ActivateOneShootWeapon()
        {
            _oneShootWeapon.WeaponModel.Activate();
            _oneShootWeaponUnlimBullets.WeaponModel.Deactivate();
            _multiShootWeapon.WeaponModel.Deactivate();
        }

        private void CreateWeapons()
        {
            int bulletsPerShootOneShootWeapon = 1;
            int bulletsPerShootMultiShootWeapon = 3;
            
            _oneShootWeapon = new Weapon(new OneShootPattern(bulletsPerShootOneShootWeapon), 10,
                false, _oneShootWeaponTemplate);

            _oneShootWeaponUnlimBullets = new Weapon(new OneShootPattern(bulletsPerShootOneShootWeapon), 99999, true, _oneShootWeaponUnlimTemplate);

            _multiShootWeapon = new Weapon(new MultiShootPattern(bulletsPerShootMultiShootWeapon), 10, false, _multiShootWeaponTemplate);
        }
    }
}