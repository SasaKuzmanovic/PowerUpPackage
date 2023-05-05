using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PowerUpManager : MonoBehaviour
{
    public GameObject speed;
    public Transform position;
    //public GameObject jump;
    public GameObject dash;
    public GameObject shot;
    public GameObject invincibility;


    private void Start()
    {
        ////////////////////////////////////////////////////
        // Set items you want active in your game to TRUE
        ////////////////////////////////////////////////////
        //speed.SetActive(true);
        //Instantiate(speed, position);
        //dash.SetActive(true);
        //Instantiate(dash);

        invincibility.SetActive(true);
        Instantiate(invincibility);
        //shot.SetActive(true);
        //Instantiate(shot);
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


}
