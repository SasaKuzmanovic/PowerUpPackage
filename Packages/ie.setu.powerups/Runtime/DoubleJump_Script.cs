using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump_Script : MonoBehaviour
{
    public static DoubleJump_Script instance;

    public float firstJump = 5.0f;
    public float secondJump = 3.0f;

    public bool spawned = false;


    public IEnumerator playerJump(Rigidbody2D t_playerRB)
    {
        t_playerRB.AddForce(Vector2.up * firstJump, ForceMode2D.Impulse);

        yield return new WaitForSeconds(0.3f);

        t_playerRB.AddForce(Vector2.up * secondJump, ForceMode2D.Impulse);

        Destroy(this.gameObject);
    }


    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }

}
