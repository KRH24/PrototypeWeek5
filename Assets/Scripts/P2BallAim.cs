using UnityEngine;

public class P2BallAim : MonoBehaviour
{
    public float rotationSpeed = 100f;      // How fast it rotates
    public float maxAngle = 60f;            // Maximum angle from center
    private float currentAngle = 0f;
    private bool rotatingRight = true;

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

        transform.rotation = Quaternion.Euler(0f, 0f, currentAngle);
    }
}
