using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{

    private int buildingLimit = 5;
    // Start is called before the first frame update
    void Start()
    {
        CreateBuilding();
    }

    private void CreateBuilding(){


    int buildingLengthSize = 1; 
    int buildingHeightSize = 1; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject building = new GameObject();
    building.name = "Building1";
    building.transform.parent = this.transform;
    building.AddComponent<Wall>();
    building.GetComponent<Wall>().initialiseWall(buildingLengthSize, buildingHeightSize, initialisePosition);
    
    building.transform.position = new Vector3(0, 0, -50f);
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    }
}
