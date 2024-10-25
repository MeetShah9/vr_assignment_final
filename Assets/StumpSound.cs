using UnityEngine;

public class StumpSound : MonoBehaviour
{
    public AudioSource stumpAudioSource;   // Assign this in the Inspector
    public AudioClip ballHitStumpClip;     // Assign your stump-hit sound clip in the Inspector

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the stumps were hit by the ball
        if (collision.gameObject.CompareTag("Ball"))  // Make sure the ball is tagged as "Ball"
        {
            stumpAudioSource.PlayOneShot(ballHitStumpClip);  // Play sound on stump collision
        }
    }
}
