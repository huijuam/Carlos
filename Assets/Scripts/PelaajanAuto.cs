using SpinMotion;
using UnityEngine;

public class PelaajanAuto : MonoBehaviour
{

    public float speed = 10f;

    public float turnSpeed = 50f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Tää on lowk aik tuff");
    }

    // Update is called once per frame
    void Update()
    {
        //pystysuuntainen liike
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //vaakasuuntainen liike
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * move);

        transform.Rotate(Vector3.up * turn);
    }
}
