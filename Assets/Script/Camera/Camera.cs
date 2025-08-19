using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;     
    public Vector3 offset;       
    public float smoothSpeed = 0.125f; 

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 desiredPosition = new Vector3(player.position.x + offset.x, offset.y, offset.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
