using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility_Script : MonoBehaviour
{
    public bool spawned = false;
    public bool gotColor = false;
    public float invincibilityTime = 4.0f;
    public Color myColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);

    public float time = 0.0f;

    public Color triggerInvisibility(Color t_playerColor)
    {
        if (!gotColor)
        {
            myColor = t_playerColor;
            gotColor = true;
        }

        var color = t_playerColor;

        return t_playerColor = new Color(color.r, color.g, color.b, 0.0f);
    }

    public Color triggerVisibility(Color t_playerColor)
    {
        t_playerColor = myColor;
        return t_playerColor;
    }

    public float timer()
    {
        if (time < 3.0f)
        {
            time += Time.deltaTime;
        }
        else
        {
            time = 0.0f;
        }

        return time;
    }

    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }
}
