using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PowerUpManager : MonoBehaviour
{
    public GameObject speed;
    public Transform position;
    public GameObject dash;
    public GameObject shot;
    public GameObject invincibility;
    public GameObject jump;
    public GameObject slowdown;
    public GameObject invisibility;
    public GameObject DoubleJump;
    public GameObject RemoveLife;



    private void Start()
    {
        ////////////////////////////////////////////////////
        // Set items you want active in your game to TRUE
        ////////////////////////////////////////////////////
        //speed.SetActive(true);
        //Instantiate(speed, position);

        //dash.SetActive(true);
        //Instantiate(dash);

        //invincibility.SetActive(true);
        //Instantiate(invincibility);

        //shot.SetActive(true);
        //Instantiate(shot);

        //jump.SetActive(true);
        //Instantiate(jump);

        //slowdown.SetActive(true);
        //Instantiate(slowdown);

        //invisibility.SetActive(true);
        //Instantiate(invisibility);

        //DoubleJump.SetActive(true);
        //Instantiate(DoubleJump);

        RemoveLife.SetActive(true);
        Instantiate(RemoveLife);
    }

    private void Update()
    {
        checkForShotFire();
        //checkForSpeedUP();
        
    }

    public void setTransformPosition(Transform t_transfrom)
    {
        position = t_transfrom;
    }

    public void checkForSpeedUP()
    {
        if (speed.gameObject.active == true)
        {
            speed.GetComponent<Speed_Script>().SpawnPickup();
        }
    }

    public void checkForShotFire()
    {
        if (shot.gameObject.active == true)
        {
            shot.GetComponent<Shot_Script>().SpawnPickup();
        }
    }

    public void checkForDash()
    {
        if (dash.gameObject.active == true)
        {
            dash.GetComponent<Shot_Script>().SpawnPickup();
        }
    }

    public void checkForInvincibility()
    {
        if (invincibility.gameObject.active == true)
        {
            invincibility.GetComponent<Invincibility_Script>().SpawnPickup();
        }
    }

    public void checkForJump()
    {
        if (jump.gameObject.active == true)
        {
            jump.GetComponent<Jump_Script>().SpawnPickup();
        }
    }

    public void checkForSlowdown()
    {
        if (slowdown.gameObject.active == true)
        {
            slowdown.GetComponent<Slowdown_Script>().SpawnPickup();
        }
    }

    public void checkForInvisibility()
    {
        if (invisibility.gameObject.active == true)
        {
            invisibility.GetComponent<Slowdown_Script>().SpawnPickup();
        }
    }

    public void checkForDoubleJump()
    {
        if (DoubleJump.gameObject.active == true)
        {
            DoubleJump.GetComponent<Slowdown_Script>().SpawnPickup();
        }
    }


}
