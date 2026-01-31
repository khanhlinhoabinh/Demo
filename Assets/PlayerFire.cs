using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval = 0.2f;

    // 👉 OFFSET BẮN ĐẠN (CHỈNH TRONG INSPECTOR)
    public Vector3 bulletOffset;

    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    void ShootBullet()
    {
        Instantiate(
            bulletPrefab,
            transform.position + bulletOffset,
            transform.rotation
        );
    }
}
