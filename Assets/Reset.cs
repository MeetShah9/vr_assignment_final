using UnityEngine;
using System.Collections;  // Required for using Coroutines

public class Reset : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private Rigidbody stumpRigidbody;

    void Start()
    {
        // Store the initial position and rotation of the stump
        initialPosition = transform.position;
        initialRotation = transform.rotation;

        // Get the Rigidbody component
        stumpRigidbody = GetComponent<Rigidbody>();
    }

    // This function resets the stumps after a 2-second delay
    IEnumerator ResetStumpsWithDelay()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(2);

        // Reset position and rotation
        transform.position = initialPosition;
        transform.rotation = initialRotation;

        // Reset velocity and angular velocity to stop any movement
        stumpRigidbody.velocity = Vector3.zero;
        stumpRigidbody.angularVelocity = Vector3.zero;
    }

    void Update()
    {
        // Check if the stump has fallen (for example, fallen below a certain X value)
        if (transform.position.x <= 90)  // Adjust the condition based on your game setup
        {
            // Start the Coroutine to reset the stump after a 2-second delay
            StartCoroutine(ResetStumpsWithDelay());
        }
    }
}
