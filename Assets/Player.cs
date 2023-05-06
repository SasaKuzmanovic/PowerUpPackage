using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D bc;
    public GameObject player;
    public float speed;


    public bool collided = false;

    public GameObject pickup;

    public GameObject dash;

    public GameObject invincibility;
    public bool invincible;
    public float invincibleTime = 0.0f;

    public GameObject bullet;
    public bool bulletCollected = false;

    public GameObject jump;

    public GameObject slowdown;
    public bool udrio = false;

    public GameObject invisibility;
    public bool invisible;
    public float invisibleTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }


        if (bulletCollected && Input.GetKey(KeyCode.Space))
        {
            bullet.GetComponent<Shot_Script>().instantiateBullet(player.transform);
        }

        if (collided)
        {
            CallPackage(pickup);
        }

        if (udrio)
        {
            SlowdownPackage(slowdown);
        }

        if (invincible)
        {
            InvincibilityPowerUP(invincibility);
        }

        if (invisible)
        {
            InvisibilityTimer();
        }
    }

    void CallPackage(GameObject t_pickup)
    {
        if (speed > 5.0f)
        {
            speed = t_pickup.GetComponent<Speed_Script>().DecaySpeedOverTime(speed);
            Debug.Log(speed);
        }
        else
        {
            speed = 5.0f;
            collided = false;
            Destroy(t_pickup);
        }
    }

    void SlowdownPackage(GameObject t_pickup)
    {
        if (speed < 5.0f)
        {
            speed = t_pickup.GetComponent<Slowdown_Script>().IncreaseSpeedOverTime(speed);
            Debug.Log(speed);
        }
        else
        {
            udrio = false;
            speed = 5.0f;
            Destroy(t_pickup);
        }
    }

    void InvincibilityPowerUP(GameObject t_invincibility)
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
        if (invincibleTime < 3.0f)
        {
            invincibleTime += Time.deltaTime;
        }
        else
        {
            Debug.Log("Not invincible");
            this.GetComponent<BoxCollider2D>().enabled = true;
            invincible = false;

            Destroy(t_invincibility);
        }

    }

    void InvisibilityTimer()
    {
        var time = invisibility.gameObject.GetComponent<Invisibility_Script>().timer();

        if (!(time < 3.0f))
        {
            gameObject.GetComponent<SpriteRenderer>().material.color = 
                invisibility.gameObject.GetComponent<Invisibility_Script>().triggerVisibility(this.gameObject.GetComponent<SpriteRenderer>().material.color);
            invisible = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            pickup = collision.gameObject;
            pickup.gameObject.transform.position = new Vector3(3000, 3000, 3000);
            speed = collision.gameObject.GetComponent<Speed_Script>().addSpeedToPlayer(speed);
            collided = true;
        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
            bullet = collision.gameObject;
            bullet.gameObject.transform.position = new Vector3(3500, 3000, 3000);
            bulletCollected = true;
        }

        if (collision.gameObject.CompareTag("Dash"))
        {
            dash = collision.gameObject;
            Debug.Log("PULSED");
            Vector2 strength = new Vector2(100.0f, 0.0f);

            dash.gameObject.transform.position = new Vector3(3500, 3000, 3000);
            rb.AddForce(Vector2.right * 5.0f, ForceMode2D.Impulse);

        }

        if (collision.gameObject.CompareTag("Invincibility"))
        {
            invincibility = collision.gameObject;
            Debug.Log("Invincible");

            invincibility.gameObject.transform.position = new Vector3(3500, 3000, 3000);

            invincible = true;
            
        }

        if (collision.gameObject.CompareTag("Jumping"))
        {
            jump = collision.gameObject;
            Debug.Log("Jumped");
            jump.gameObject.transform.position = new Vector3(3500, 3000, 3000);


            rb.AddForce(Vector2.up * 10.0f, ForceMode2D.Impulse);

            Destroy(jump);

        }


        if (collision.gameObject.CompareTag("Slowdown"))
        {
            slowdown = collision.gameObject;
            slowdown.gameObject.transform.position = new Vector3(3000, 3000, 3000);
            speed = collision.gameObject.GetComponent<Slowdown_Script>().removeSpeedFromPlayer(speed);
            udrio = true;
        }

        if (collision.gameObject.CompareTag("Invisibility"))
        {
            invisibility = collision.gameObject;
            Debug.Log("Invisible");

            gameObject.GetComponent<SpriteRenderer>().material.color = 
                invisibility.gameObject.GetComponent<Invisibility_Script>().triggerInvisibility(this.gameObject.GetComponent<SpriteRenderer>().material.color);
            invisible = true;
        }
    }
}
