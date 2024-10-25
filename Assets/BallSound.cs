using UnityEngine;

public class BallSound : MonoBehaviour
{
    public AudioSource ballAudioSource;  // Assign this in the Inspector
    public AudioClip ballHitGroundClip;  // Assign your ground-hit sound clip in the Inspector

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the ball has collided with the ground
        if (collision.gameObject.CompareTag("Ground"))  // Make sure your ground object is tagged as "Ground"
        {
            ballAudioSource.PlayOneShot(ballHitGroundClip);  // Play sound on ground collision
        }
    }
}
