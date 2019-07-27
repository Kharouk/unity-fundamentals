using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"We hit the {collision.collider.name.ToLower()}.");

        if (collision.collider.name == "Obstacle")
        {
            Debug.Log("Game Over.");
        }
    }
}
