using System.Collections;
using System.Collections.Generic;
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

        if (invincible)
        {
            InvincibilityPowerUP(invincibility);
        }
    }

    void CallPackage(GameObject t_pickup)
    {
        if (speed > 5.0f)
        {
            speed = t_pickup.GetComponent<Speed_Script>().DecaySpeedOverTime(speed);
            Debug.Log(speed);
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
    }
}
