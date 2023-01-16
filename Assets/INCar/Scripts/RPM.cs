using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPM : MonoBehaviour
{
    public GameObject arrow;
    private float revolutions = 0;
    private float turnSpeed;
    Quaternion DefaultRotation = Quaternion.Euler(0, 0, 0);
    Quaternion CurrentRotation;

    public void Start()
    {
        arrow.transform.rotation = DefaultRotation;
    }

    public void Update()
    {

        CurrentRotation = arrow.transform.rotation;
       


        if (Input.GetKey(KeyCode.W))
        {
           

            

             if(revolutions < 0)
            {
                revolutions = 0;
                arrow.transform.rotation = Quaternion.Euler(0,0,0);
               
            }
            if  (revolutions >= 40000)
            {
                revolutions = 40000;
                arrow.transform.rotation = CurrentRotation;
            }
             else
            {
                
                arrow.transform.Rotate(-Vector3.forward * Time.deltaTime * turnSpeed);
                revolutions += turnSpeed;
            }



        }
        else if (Input.GetKey(KeyCode.S))
        {

            if (revolutions < 0)
            {
                arrow.transform.rotation = Quaternion.Euler(0,0,0);
                revolutions = 0;
            }
            else
            {

                arrow.transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed);
                revolutions -= turnSpeed;
            }

        }
        else
        {
           
            if (revolutions < 0)
            {
                arrow.transform.rotation = Quaternion.Euler(0,0,0);
                revolutions = 0;
            }

            if (revolutions > 0)
            {
                arrow.transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed);
                revolutions -= turnSpeed;
            }
           
            

        }



    }


}
