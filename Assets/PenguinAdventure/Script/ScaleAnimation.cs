using UnityEngine;

public class ScaleAnimation : MonoBehaviour
{
    public float scaleSpeed = 2f; // Speed of scaling
    public float minScale = 0.8f; // Minimum scale value
    public float maxScale = 1.2f; // Maximum scale value
    private float scaleDirection = 1f; // Direction of scaling

    void Update()
    {
        transform.localScale += Vector3.one * scaleSpeed * scaleDirection * Time.deltaTime;
        if (transform.localScale.x >= maxScale || transform.localScale.x <= minScale)
        {
            scaleDirection *= -1; // Reverse direction
        }
    }
}