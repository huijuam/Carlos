using UnityEngine;

public class Maaliviiva : MonoBehaviour
{
    private void OnTriggerEnter(Collider auto)
    {
        var id = auto.GetComponent<CarIdentity>();
        Debug.Log("Mitä sanoit" + id.car_name);
    }
}
