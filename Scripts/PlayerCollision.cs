using UnityEngine;

public class PlayerCollision : Subject
{
    public PlayerMovement movement;
    public bool death = false;


    public void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Death();
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }

    public void Death()
    {
        death = true;
        NotifyObservers();
    }
}
