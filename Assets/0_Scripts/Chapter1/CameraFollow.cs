using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float followDistance = 5f;
    public float followHeight = 2f;
    public float smoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        // Calculate the desired position of the camera
        Vector3 targetPosition = target.position - (target.forward * followDistance) + (Vector3.up * followHeight);

        // Smoothly move the camera to the desired position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        // Look at the target
        transform.LookAt(target);
    }
}
