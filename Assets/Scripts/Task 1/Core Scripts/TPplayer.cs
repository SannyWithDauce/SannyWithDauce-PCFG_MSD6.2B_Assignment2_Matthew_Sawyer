using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPplayer : MonoBehaviour
{
    public Transform tpTarget;
    public GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        //CharacterController cc = thePlayer.GetComponent<CharacterController>();
        //cc.enabled = false;
        thePlayer.transform.position = tpTarget.transform.position;
        Debug.Log("entered");
        //cc.enabled = true;
    }
}
