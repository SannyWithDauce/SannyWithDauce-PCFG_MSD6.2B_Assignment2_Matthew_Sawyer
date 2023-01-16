using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsBuilderRoad
{
    private List<Material> materialsListRoad = new List<Material>();

    public MaterialsBuilderRoad()
    {
        Material yourMaterialRoad = Resources.Load("Tarmac", typeof(Material)) as Material;

        //yourMaterialRoad.AddComponent<MeshCollider>();

        materialsListRoad.Add(yourMaterialRoad);
        materialsListRoad.Add(yourMaterialRoad);
        materialsListRoad.Add(yourMaterialRoad);
        materialsListRoad.Add(yourMaterialRoad);
        materialsListRoad.Add(yourMaterialRoad);
        materialsListRoad.Add(yourMaterialRoad);
    }

    public List<Material> MaterialsListRoad(){
        return materialsListRoad;
    }
}
