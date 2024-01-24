using UnityEngine;

namespace Task2_Weapon_.Scripts.Models
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Bullet _bullet;
        [SerializeField] private float _speed;

        public void Init(Transform spawnPointTransform)
        {
            Instantiate(_bullet, spawnPointTransform.position, Quaternion.identity);
        }
        
        private void Update()
        {
            Vector3 direction = new Vector3(0, 0, 1);
            transform.Translate(direction.normalized * (_speed * Time.deltaTime));
        }

    }
}
