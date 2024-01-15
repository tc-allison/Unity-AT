using UnityEngine;
using TMPro;

public class TimeLimitController : MonoBehaviour
{
    public float timeLimit = 120.0f; // Set the initial time limit in seconds
    private TextMeshProUGUI timeLimitText;

    void Start()
    {
        // Find the TextMeshProUGUI component on the canvas
        timeLimitText = GetComponentInChildren<TextMeshProUGUI>();

        if (timeLimitText == null)
        {
            Debug.LogError("TextMeshProUGUI component not found. Make sure it's a child or component of the script's GameObject.");
        }
        else
        {
            // Set the initial time limit text
            UpdateTimeLimitText();
        }
    }
    void Update()
    {
        // Subtract elapsed time
        timeLimit -= Time.deltaTime;

        // Update UI
        UpdateTimeLimitText();

        // Check if time has run out
        if (timeLimit <= 0.0f)
        {
            // Implement your game over logic here
            Debug.Log("Time's up!");
        }
    }

    void UpdateTimeLimitText()
    {
        // Display the time remaining in a formatted way (you can customize this)
        if (timeLimitText != null)
        {
            timeLimitText.text = "Time: " + Mathf.Ceil(timeLimit).ToString();
        }
    }
}