using UnityEngine;
using TMPro;  // Import TextMeshPro namespace

public class GameScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // Reference to the TextMeshProUGUI component for displaying score
    private int score = 0;  // Player's score

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the paper ball
        if (other.gameObject.CompareTag("Ball"))
        {
            

            // Increment score
            IncreaseScore();

            
        }
    }

    // Function to increase the score and update the UI
    private void IncreaseScore()
    {
        score += 1;  // Increase score by 1
        scoreText.text = "Score: " + score;  // Update the score UI
        Debug.Log("Current Score: " + score);  // Optional log for testing
    }
}
