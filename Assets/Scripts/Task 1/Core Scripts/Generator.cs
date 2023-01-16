using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public GameObject Building1;
    public GameObject Building2;
    public GameObject Building3;
    public GameObject Building4;
    public GameObject Building5;

    public int xPos;
    public int zPos;
    public int objectToGenerate;
    public int objectQuantity;

    void Start()
    {
        StartCoroutine(GenerateObjects());
    }

    IEnumerator GenerateObjects()
    {
        while(objectQuantity < 5)
        {
            objectToGenerate = Random.Range(1, 6);
            xPos = Random.Range(80, 20);
            zPos = Random.Range(-120, -180);
            if(objectToGenerate == 1)
            {
                Instantiate(Building1, new Vector3(xPos, 0, zPos), Quaternion.identity);
            }
            if(objectToGenerate == 2)
            {
                Instantiate(Building2, new Vector3(xPos, 0, zPos), Quaternion.identity);
            }
            if(objectToGenerate == 3)
            {
                Instantiate(Building3, new Vector3(xPos, 0, zPos), Quaternion.identity);
            }
            if(objectToGenerate == 4)
            {
                Instantiate(Building4, new Vector3(xPos, 0, zPos), Quaternion.identity);
            }
            if(objectToGenerate == 5)
            {
                Instantiate(Building5, new Vector3(xPos, 0, zPos), Quaternion.identity);
            }
            yield return new WaitForSeconds(0.01f);
            objectQuantity += 1;
        }
    }

    void Update()
    {
        
    }
}
