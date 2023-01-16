using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringWheel : MonoBehaviour
{
    public GameObject Wheel;
    public int turnSpeed;
    Quaternion defaultRotation;
    Quaternion actualRotation;
    public int rotations = 0;


    void Start()
    {
        defaultRotation = Quaternion.Euler(0, 0, 0);
    }

    public void Update()
    {

        actualRotation = Wheel.transform.rotation;

        if (Input.GetKey(KeyCode.A))
        {

            Wheel.transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed);

            rotations -= turnSpeed;

            if (rotations < -228000)
            {
                Wheel.transform.rotation = actualRotation;
                rotations = -228000;
            }

        }
        else if (Input.GetKey(KeyCode.D))
        {

            Wheel.transform.Rotate(-Vector3.forward * Time.deltaTime * turnSpeed);

            rotations += turnSpeed;

            if (rotations > 228000)
            {
                Wheel.transform.rotation = actualRotation;
                rotations = 228000;
            }

        }
        else
        {
            if (rotations > 0)
            {

                Wheel.transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed);
                rotations -= turnSpeed;

            }
            else if (rotations < 0)
            {
                Wheel.transform.Rotate(-Vector3.forward * Time.deltaTime * turnSpeed);
                rotations += turnSpeed;

            }
            else if (rotations == 0)
            {
                Wheel.transform.localRotation = defaultRotation;
            }

        }



    }

}
