using System.Data.Common;
using System.Diagnostics;
using UnityEngine;

public class Checkpoint : Monobehaviour
{
    public int orderIndex = 0;
    private void OnTriggerEnter(Collider auto)
    {
        Debug.Log("Checkpointtiin" + orderIndex + "osui" + id.car_name);
        var tarkastaja = auto.GetComponent<CheckpointTarkastus>();
        tarkastaja.MarkVisited(orderIndex);
    }
}