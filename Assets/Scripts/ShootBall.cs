using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject ballPrefab;           // Assign the ball prefab in Inspector
    public Transform shootPoint;            // Tip of the arrow
    public float shootForce = 10f;          // Speed of the ball
    public KeyCode shootKey = KeyCode.Space; // Player-specific shoot key

    private bool hasShot = false;

    void Update()
    {
        if (!hasShot && Input.GetKeyDown(shootKey))
        {
            Shoot();
            Destroy(ballPrefab, 3f);
        }
    }

    void Shoot()
    {
        GameObject ball = Instantiate(ballPrefab, shootPoint.position, Quaternion.identity);
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        rb.velocity = shootPoint.up * shootForce;

        hasShot = true;

       
        shootPoint.parent.gameObject.SetActive(false);
    }
}
