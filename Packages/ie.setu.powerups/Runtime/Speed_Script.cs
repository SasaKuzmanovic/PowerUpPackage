using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Script : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float timer = 0.0f;
    public float timerEnd = 5.0f; // Define how long you want the timer to be
    public bool timeStart = false;
    public bool spawned = false;

    private void Update()
    {
        if (timeStart)
        {
            speedTimer();
            DecaySpeedOverTime();
        }
    }


    public void addSpeedToPlayer()
    {
        player.GetComponent<Player>().speed *= 1.2f;
        speed = player.GetComponent<Player>().speed;
    }

    public void speedTimer()
    {
        if (timer < timerEnd)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timeStart = false;
            timer = 0.0f;
        }
        

    }

    public void DecaySpeedOverTime()
    {
        if (timer < timerEnd && speed > 5.0f)
        {
            speed = player.GetComponent<Player>().speed;

            speed += (-0.22f * Time.deltaTime);
            player.GetComponent<Player>().speed = speed;
        }
    }

    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("I Ded");
            transform.position = new Vector3(3000, 3000, 3000);
            addSpeedToPlayer();
            timeStart = true;
        }
    }

}
