using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building6Part2 : MonoBehaviour
{
    void Start()
    {
        CreatingBuilding1();
    }

    private void  CreatingBuilding1(){

        int newWallLengthSize = 1; 
        int newWallHeightSize = 1; 
        Vector3 newInitialPosition = new Vector3(0f, 0, 0); 
        Vector3 newWallCubeSize = new Vector3(17, 9, 6);   

        GameObject wall = new GameObject();
        wall.name = "Wall";
        wall.AddComponent<Wall>();
        wall.GetComponent<Wall>().InitialiseWall(newWallLengthSize,newWallHeightSize,newInitialPosition,newWallCubeSize);
        wall.transform.parent = this.transform;

        Vector3 rotation = new Vector3(0, 0, 0);
        this.transform.Rotate(rotation);
        this.transform.position = new Vector3(0,7,0);
    }
}
