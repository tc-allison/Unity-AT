// InputHandler.cs
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject gun;
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Adjust "Fire1" to your desired input
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Debug.Log("Shooting!");
        // Instantiate a bullet at the firePoint position and rotation
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Debug.Log("Bullet Instantiated!");
    }
}