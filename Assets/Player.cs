using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public float speed;


    public bool collided = false;

    public GameObject pickup;


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


        //if (bulletCollected && Input.GetKey(KeyCode.Space))
        //{
        //    bullet.GetComponent<Shot_Script>().instantiateBullet(player.transform);
        //}   

        if (collided)
        {
            CallPackage(pickup);
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


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            pickup = collision.gameObject;
            pickup.gameObject.transform.position = new Vector3(3000, 3000, 3000);
            speed = collision.gameObject.GetComponent<Speed_Script>().addSpeedToPlayer(speed);
            collided = true;            
        }

        //if (collision.gameObject.CompareTag("Bullet"))
        //{
        //    bullet = collision.gameObject;
        //    bullet.gameObject.transform.position = new Vector3(3500, 3000, 3000);
        //    bulletCollected = true;
        //}
    }


}
