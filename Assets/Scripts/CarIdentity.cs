using System.Collections.Generic;
using UnityEngine;

public enum CarType { Player, AI }
public class CarIdentity : MonoBehaviour
{


   public CarType type = CarType.Player;
public string car_name = "Pelaaja";
}
