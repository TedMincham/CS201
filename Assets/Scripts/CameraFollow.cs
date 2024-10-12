using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset; // Offset distance between the player and camera
    public float smoothSpeed = 0.125f; // Speed of smoothing the camera movement

    void LateUpdate()
    {
        // Desired position is the player's position plus the offset
        Vector3 desiredPosition = player.position + offset;

        // Smoothly interpolate between current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        // Set the camera's position to the smoothed position
        transform.position = smoothedPosition;

        // Optionally, have the camera always look at the player
        transform.LookAt(player);
    }
}
