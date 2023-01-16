using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public void GetInput()
    {
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_VerticalInput = Input.GetAxis("Vertical");
    }

    private void Steer()
    {
        m_steeringAngle = maxSteeringAngle * m_horizontalInput;
        frontLeft.steerAngle = m_steeringAngle;
        frontRight.steerAngle = m_steeringAngle;
    }

    private void Accelerate()
    {
        frontLeft.motorTorque = m_VerticalInput * MotorForce;
        frontRight.motorTorque = m_VerticalInput * MotorForce;
    }

    private void UpdateWheelPoses()
    {
        UpdateWheelPose(frontLeft, Fl);
        UpdateWheelPose(frontRight, Fr);
        UpdateWheelPose(RearLeft, Rl);
        UpdateWheelPose(RearRight, Rr);

    }

    private void UpdateWheelPose(WheelCollider _wheelcolider, Transform _transform)
    {
        Vector3 _pos = _transform.position;
        Quaternion _quat = transform.rotation;

        _wheelcolider.GetWorldPose(out _pos, out _quat);

        _transform.position = _pos;
        _transform.rotation = _quat;

    }

    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        UpdateWheelPoses(); 

    }


    private float m_horizontalInput;
    private float m_VerticalInput;
    private float m_steeringAngle;


    public WheelCollider frontLeft, frontRight;
    public WheelCollider RearLeft, RearRight;

    public Transform Fr, Fl;
    public Transform Rr, Rl;

    public float maxSteeringAngle = 30;
    public float MotorForce = 500;




    
}
