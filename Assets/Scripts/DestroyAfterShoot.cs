using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float lifetime = 3f; // Time in seconds before destroying the ball

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
