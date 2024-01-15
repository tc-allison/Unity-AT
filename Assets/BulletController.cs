// BulletController.cs

using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;  // Adjust the speed as needed

    void Start()
    {
        // Set the initial velocity of the bullet
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Handle collision logic here, for example, destroy the bullet on impact
        Destroy(gameObject);
    }
}