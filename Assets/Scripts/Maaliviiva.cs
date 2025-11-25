using TMPro;
using UnityEngine;

public class Maaliviiva : MonoBehaviour
{
    private bool winnerDeclared = false;

    [SerializeField] private TextMeshProUGUI winnerText;
    

    private void OnTriggerEnter(Collider auto)
    {
        var id = auto.GetComponent<CarIdentity>();
        var tarkastaja = auto.GetComponent<CheckpointTarkistus>();
        if (tarkastaja.CanWin())
        {
            if (tarkastaja.laps == GameManager.Instance.LapsToWin && !winnerDeclared)
            {
                winnerDeclared = true;
                winnerText.text = "Race finished,\nwinner being " + id.car_name;

                if (id.type == CarType.Player)
                {
                    winnerText.color = Color.green;
                }
                else
                {
                    winnerText.color = Color.red;
                }

                winnerText.gameObject.SetActive(true);
                GameManager.Instance.gameRunning = false;
            }
            else
            {
                tarkastaja.ResetLap();
            }
            Debug.Log("Mitä sanoit " + id.car_name);
            tarkastaja.ResetLap();
        }
        
    }
}
