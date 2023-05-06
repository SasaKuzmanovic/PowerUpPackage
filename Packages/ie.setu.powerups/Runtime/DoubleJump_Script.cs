using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump_Script : MonoBehaviour
{
    public static DoubleJump_Script instance;

    public float firstJump = 5.0f;
    public float secondJump = 3.0f;

    public bool spawned = false;





    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }

}
