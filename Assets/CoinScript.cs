using StarterAssets;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float rotationSpeed = 100f;

    private void Update()
    {
        // Rotate the coin
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<ThirdPersonController>().IncreaseCoinCount();

            // Handle coin pickup (e.g., increase player score)
            Destroy(gameObject); // Destroy the coin
        }
    }
}