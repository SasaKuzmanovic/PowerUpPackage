using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility_Script : MonoBehaviour
{
    public static Invincibility_Script instance;

    public bool spawned = false;
    public float invincibilityTime = 3.0f;
    public float time = 0.0f;


    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }

    public float timer()
    {
        if (time < invincibilityTime)
        {
            time += Time.deltaTime;
        }

        return time;
    }
}
