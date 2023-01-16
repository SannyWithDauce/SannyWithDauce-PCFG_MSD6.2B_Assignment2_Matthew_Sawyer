using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedMeter : MonoBehaviour
{

    public GameObject arrow;
    private float turnSpeed;
    Quaternion defaultRotation;
    Quaternion actualRotation;
    private float rotations = 0;

    void Start()
    {
        defaultRotation = Quaternion.Euler(0, 0, 20);
    }

   
    void Update()
    {
        actualRotation.z = arrow.transform.rotation.z;
        actualRotation.y = 0;
        actualRotation.x = 0;
        if (Input.GetKey(KeyCode.W))
        {
            arrow.transform.Rotate(-Vector3.forward * Time.deltaTime * turnSpeed);
            rotations += turnSpeed;

            if (rotations >= 60000)
            {
                arrow.transform.rotation = actualRotation;
                rotations = 60000;
            }
           
        }
        else if (Input.GetKey(KeyCode.S))
        {
           

            if (rotations <= 0)
            {
                arrow.transform.rotation = Quaternion.Euler(0, 0, 20);
                rotations = 0;
            }
           
            else
            {
                arrow.transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed * 4);
                
                rotations -= turnSpeed * 4;
            }

        }

        else
        {
            if (rotations > 0)
            {

                arrow.transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed);
                rotations -= turnSpeed;

            }

            else if (rotations < 0) 
            {

                rotations = 0;
                arrow.transform.rotation = defaultRotation;
            }

            else if (rotations == 0)
            {
                rotations = 0;
                arrow.transform.localRotation = defaultRotation;
            }
        }
            
        

    }
}
