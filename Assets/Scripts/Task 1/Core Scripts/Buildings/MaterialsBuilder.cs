using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsBuilder
{
    private List<Material> materialsList = new List<Material>();

    public MaterialsBuilder()
    {
        Material yourMaterial = Resources.Load("BrickMain", typeof(Material)) as Material;

        materialsList.Add(yourMaterial);
        materialsList.Add(yourMaterial);
        materialsList.Add(yourMaterial);
        materialsList.Add(yourMaterial);
        materialsList.Add(yourMaterial);
        materialsList.Add(yourMaterial);   
    }

    public List<Material> MaterialsList(){
        return materialsList;
    }
}
