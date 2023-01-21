using UnityEngine;

public class collision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "ghost")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
} 