using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash_Script : MonoBehaviour
{
    public GameObject player;
    public Vector2 strength = new Vector2 (5.0f, 0.0f);
    public bool spawned = false;



    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }
}
