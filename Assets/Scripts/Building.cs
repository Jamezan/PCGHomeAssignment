using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        CreateBuilding();
        CreateBuilding2();
        CreateBuilding3();
        CreateBuilding4();
        CreateBuilding5();
        CreateBuilding6();
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
    
    //-71 - -20
    building.transform.localPosition = new Vector3(19f, 29f, Random.Range(-71f, -20f));
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    BoxCollider collider = building.AddComponent<BoxCollider>();
    collider.center = new Vector3(0f, -0.01442289f, 10.01676f);
    collider.size = new Vector3(2.20023799f, 2.04105639f, 2.11126399f);
    }
    private void CreateBuilding2(){


    int buildingLengthSize = 1; 
    int buildingHeightSize = 1; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject building = new GameObject();
    building.name = "Building2";
    building.transform.parent = this.transform;
    building.AddComponent<Wall>();
    building.GetComponent<Wall>().initialiseWall(buildingLengthSize, buildingHeightSize, initialisePosition);
    
    //-111 - -160
    building.transform.localPosition = new Vector3(19f, 29f, Random.Range(-111f, -160f));
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    BoxCollider collider = building.AddComponent<BoxCollider>();
    collider.center = new Vector3(0f, -0.01442289f, 10.01676f);
    collider.size = new Vector3(2.20023799f, 2.04105639f, 2.11126399f);
    }
    private void CreateBuilding3(){


    int buildingLengthSize = 1; 
    int buildingHeightSize = 1; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject building = new GameObject();
    building.name = "Building3";
    building.transform.parent = this.transform;
    building.AddComponent<Wall>();
    building.GetComponent<Wall>().initialiseWall(buildingLengthSize, buildingHeightSize, initialisePosition);
    
    //-111 - -160
    building.transform.localPosition = new Vector3(170f, 29f, Random.Range(-111f, -160f));
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    BoxCollider collider = building.AddComponent<BoxCollider>();
    collider.center = new Vector3(0f, -0.01442289f, 10.01676f);
    collider.size = new Vector3(2.20023799f, 2.04105639f, 2.11126399f);
    }
    private void CreateBuilding4(){


    int buildingLengthSize = 1; 
    int buildingHeightSize = 1; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject building = new GameObject();
    building.name = "Building4";
    building.transform.parent = this.transform;
    building.AddComponent<Wall>();
    building.GetComponent<Wall>().initialiseWall(buildingLengthSize, buildingHeightSize, initialisePosition);
    
    //-71 - -20
    building.transform.localPosition = new Vector3(170f, 29f, Random.Range(-71f, -20f));
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    BoxCollider collider = building.AddComponent<BoxCollider>();
    collider.center = new Vector3(0f, -0.01442289f, 10.01676f);
    collider.size = new Vector3(2.20023799f, 2.04105639f, 2.11126399f);
    }
    private void CreateBuilding5(){


    int buildingLengthSize = 1; 
    int buildingHeightSize = 1; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject building = new GameObject();
    building.name = "Building5";
    building.transform.parent = this.transform;
    building.AddComponent<Wall>();
    building.GetComponent<Wall>().initialiseWall(buildingLengthSize, buildingHeightSize, initialisePosition);
    
    //-71 - 0
    building.transform.localPosition = new Vector3(Random.Range(59f, 129f), 29f, -71f);
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    BoxCollider collider = building.AddComponent<BoxCollider>();
    collider.center = new Vector3(0f, -0.01442289f, 10.01676f);
    collider.size = new Vector3(2.20023799f, 2.04105639f, 2.11126399f);
    }
    private void CreateBuilding6(){


    int buildingLengthSize = 1; 
    int buildingHeightSize = 1; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject building = new GameObject();
    building.name = "Building6";
    building.transform.parent = this.transform;
    building.AddComponent<Wall>();
    building.GetComponent<Wall>().initialiseWall(buildingLengthSize, buildingHeightSize, initialisePosition);
    
    //-71 - 0
    building.transform.localPosition = new Vector3(Random.Range(59f, 129f), 29f, -111f);
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    BoxCollider collider = building.AddComponent<BoxCollider>();
    collider.center = new Vector3(0f, -0.01442289f, 10.01676f);
    collider.size = new Vector3(2.20023799f, 2.04105639f, 2.11126399f);
    }
}
