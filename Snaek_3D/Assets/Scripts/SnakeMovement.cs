using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{

    public float FartFram = 1; 
    public float StyrFart = 180;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //r�ra fram�t
        transform.position += transform.forward * FartFram * Time.deltaTime;

        //styra h�ger v�nster
        float StyrVinkel = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * StyrVinkel * StyrFart * Time.deltaTime);



        

    }
}
