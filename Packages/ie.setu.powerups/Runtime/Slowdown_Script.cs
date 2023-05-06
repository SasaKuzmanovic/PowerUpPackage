using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowdown_Script : MonoBehaviour
{
    public float speed;
    public bool spawned = false;

    public float removeSpeedFromPlayer(float t_speed)
    {
        speed = t_speed / 1.2f;

        return speed;
    }

    public float IncreaseSpeedOverTime(float t_speed)
    {
        if (speed < 5.0f)
        {
            t_speed += (0.22f * Time.deltaTime);

            return t_speed;
        }
        return t_speed;
    }

    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }
}
