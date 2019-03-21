using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Movement;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            // Turn off player movement script when collide with obstacle
            Movement.enabled = false;
            // Print message when collide with obstacle object
            Debug.Log("Hit on an obstacle");

        }
    }
}
