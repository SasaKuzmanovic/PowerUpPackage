using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility_Script : MonoBehaviour
{
    public static Invincibility_Script instance;

    public bool spawned = false;
    public float invincibilityTime = 1.0f;


    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }
}
