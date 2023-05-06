using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility_Script : MonoBehaviour
{
    public bool spawned = false;
    public float invisibilityTime = 3.0f;


    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }
}
