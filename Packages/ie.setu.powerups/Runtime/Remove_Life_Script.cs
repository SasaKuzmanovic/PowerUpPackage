using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Codice.Client.Common.Servers.RecentlyUsedServers;

public class Remove_Life_Script : MonoBehaviour
{
    public int removeHealthBy = 1;

    public bool spawned = false;

    public void removePlayersHealth(ref int t_health)
    {
        t_health = t_health - removeHealthBy;
    }


    public void SpawnPickup()
    {
        if (!spawned)
            Instantiate(this); spawned = true;
    }

}
