using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash_Script : MonoBehaviour
{
    public bool spawned = false;

    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }
}
