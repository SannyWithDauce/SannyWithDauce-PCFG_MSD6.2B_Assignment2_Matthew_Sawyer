using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private GameObject Meshy;

    // Start is called before the first frame update
    void Start()
    {
        //Meshy = GameObject.Find("/WallRoad/CubeRoad 0-0");
        //Meshy.AddComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        Meshy = GameObject.Find("CubeRoad 0-0");
        Meshy.AddComponent<MeshCollider>();
    }
}
