using UnityEngine;

public class P1BallAim : MonoBehaviour
{
    public float rotationSpeed = 100f;      // How fast it rotates
    public float maxAngle = 60f;            // Maximum angle from center
    private float currentAngle = 0f;
    private bool rotatingRight = false;

    void Update()
    {
        float angleChange = rotationSpeed * Time.deltaTime;

        if (rotatingRight)
        {
            currentAngle += angleChange;
            if (currentAngle >= maxAngle)
            {
                currentAngle = maxAngle;
                rotatingRight = false;
            }
        }
        else
        {
            currentAngle -= angleChange;
            if (currentAngle <= -maxAngle)
            {
                currentAngle = -maxAngle;
                rotatingRight = true;
            }
        }

        transform.localRotation = Quaternion.Euler(0f, 0f, currentAngle);
    }
}
