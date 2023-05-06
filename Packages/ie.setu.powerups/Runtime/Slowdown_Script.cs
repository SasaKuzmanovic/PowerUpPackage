using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowdown_Script : MonoBehaviour
{
    public float speed;
    public bool spawned = false;


    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }
}
