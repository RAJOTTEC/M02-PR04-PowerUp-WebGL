using UnityEngine;

public class PlayerMovement : Subject
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public bool moveDeath = false;
    public bool flying = false;
    float timer = 0f;
    float limit = 2f;


    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            Death();
            FindObjectOfType<GameManager>().EndGame();
        }

        if(rb.position.y > 1.5f)
        {
            Flying();
        }
    }

    public void Death()
    {
        moveDeath = true;
        NotifyObservers();
    }

    public void Flying()
    {
        flying = true;
        NotifyObservers();

        timer += Time.deltaTime;
        if(timer >= limit)
        {
            flying = false;
            NotifyObservers();
        }
    }
}
