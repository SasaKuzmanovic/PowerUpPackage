using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot_Script : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;

    public bool spawned = false;

    

    //public void instantiateBullet(Transform t_playerPos)
    //{
    //    Instantiate(bullet, t_playerPos);
    //}


    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }
}
