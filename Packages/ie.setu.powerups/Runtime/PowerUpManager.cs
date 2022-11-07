using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PowerUpManager : MonoBehaviour
{
    public GameObject speed;
    //public GameObject jump;
    //public GameObject invincibility;
    //public GameObject dash;
    //public GameObject shot;


    private void Start()
    {
        ////////////////////////////////////////////////////
        // Set items you want active in your game to TRUE
        ////////////////////////////////////////////////////
        speed.SetActive(true);
        Instantiate(speed);
        //jump.SetActive(false);
        //invincibility.SetActive(false);
        //dash.SetActive(false);
        //shot.SetActive(false);
    }

    private void Update()
    {
        checkForSpeedUP();
    }


    public void checkForSpeedUP()
    {
        if (speed.gameObject.active == true)
        {
            speed.GetComponent<Speed_Script>().SpawnPickup();
        }
    }

    //public void checkForAddJump()
    //{
    //    if (jump.gameObject.active == true)
    //    {
            
    //    }
    //}

    //public void checkForInvincibility()
    //{
    //    if (invincibility.gameObject.active == true)
    //    {
            
    //    }
    //}

    //public void checkForDash()
    //{
    //    if (dash.gameObject.active == true)
    //    {
            
    //    }
    //}

    //public void checkForShotFire()
    //{
    //    if (shot.gameObject.active == true)
    //    {
            
    //    }
    //}
}
