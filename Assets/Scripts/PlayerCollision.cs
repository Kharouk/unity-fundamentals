using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"We hit the {collision.collider.name.ToLower()}."); 

        // check for tag rather than name since name can be changed.
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("Game Over.");
            movement.enabled = false;
        }
    }
}
