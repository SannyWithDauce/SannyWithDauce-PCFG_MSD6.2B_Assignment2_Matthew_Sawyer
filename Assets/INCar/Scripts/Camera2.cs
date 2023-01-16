using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{

    public void LookAtTarget()
    {
        Vector3 _lookDirection = ObjectToFollow.position - transform.position;
        Quaternion _rot = Quaternion.LookRotation(_lookDirection, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, _rot, lookspeed * Time.deltaTime);

    }

    public void MoveToTarget()
    {
        Vector3 targetPosition = ObjectToFollow.position +
                                                     ObjectToFollow.forward * Offset.z +
                                                     ObjectToFollow.right * Offset.x +
                                                     ObjectToFollow.up * Offset.y;

        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed *  Time.deltaTime);

    }

    public void FixedUpdate()
    {
        LookAtTarget();
        MoveToTarget();
    }

    public Transform ObjectToFollow;
    public Vector3 Offset;
    public float followSpeed = 10;
    public float lookspeed = 10;

}
