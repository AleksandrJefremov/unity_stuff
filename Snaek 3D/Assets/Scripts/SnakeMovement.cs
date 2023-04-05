using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{

    public float FartFram = 0; 
    public float StyrFart = 0;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //röra framåt
        //transform.position += transform.forward * FartFram * Time.deltaTime;

        //styra höger vänster
        float StyrVinkel = Input.GetAxis("Horizontal");
        //transform.Rotate(Vector3.up * StyrVinkel * StyrFart * Time.deltaTime);



        

    }
}
