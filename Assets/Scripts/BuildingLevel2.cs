using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingLevel2 : MonoBehaviour
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
        CreateBuilding7();
        CreateBuilding8();
        CreateBuilding9();
        CreateBuilding10();
    }

    private void CreateBuilding(){


    int buildingLengthSize = 1; 
    int buildingHeightSize = 1; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject building = new GameObject();
    building.name = "Building";
    building.transform.parent = this.transform;
    building.AddComponent<Wall>();
    building.GetComponent<Wall>().initialiseWall(buildingLengthSize, buildingHeightSize, initialisePosition);
    
    //-60 - -120
    building.transform.localPosition = new Vector3(14f, 29f, Random.Range(-60f, -120f));
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
    
    //-21 - 10
    building.transform.localPosition = new Vector3(14f, 29f, Random.Range(-21f, 10f));
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
    
    //-160 - -170
    building.transform.localPosition = new Vector3(14f, 29f, Random.Range(-160f, -170f));
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
    
    //119 - 55
    building.transform.localPosition = new Vector3(Random.Range(119f, 55f), 29f, -161f);
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
    
    //224 - 159
    building.transform.localPosition = new Vector3(Random.Range(224f, 159f), 29f, -161f);
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
    
    //-60 - -120
    building.transform.localPosition = new Vector3(264f, 29f, Random.Range(-60f, -120f));
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    BoxCollider collider = building.AddComponent<BoxCollider>();
    collider.center = new Vector3(0f, -0.01442289f, 10.01676f);
    collider.size = new Vector3(2.20023799f, 2.04105639f, 2.11126399f);
    }
    private void CreateBuilding7(){


    int buildingLengthSize = 1; 
    int buildingHeightSize = 1; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject building = new GameObject();
    building.name = "Building7";
    building.transform.parent = this.transform;
    building.AddComponent<Wall>();
    building.GetComponent<Wall>().initialiseWall(buildingLengthSize, buildingHeightSize, initialisePosition);
    
    //224 - 159
    building.transform.localPosition = new Vector3(Random.Range(224f, 159f), 29f, -21f);
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    BoxCollider collider = building.AddComponent<BoxCollider>();
    collider.center = new Vector3(0f, -0.01442289f, 10.01676f);
    collider.size = new Vector3(2.20023799f, 2.04105639f, 2.11126399f);
    }
    private void CreateBuilding8(){


    int buildingLengthSize = 1; 
    int buildingHeightSize = 1; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject building = new GameObject();
    building.name = "Building8";
    building.transform.parent = this.transform;
    building.AddComponent<Wall>();
    building.GetComponent<Wall>().initialiseWall(buildingLengthSize, buildingHeightSize, initialisePosition);
    
    //119 - 55
    building.transform.localPosition = new Vector3(Random.Range(119f, 55f), 29f, -21f);
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    BoxCollider collider = building.AddComponent<BoxCollider>();
    collider.center = new Vector3(0f, -0.01442289f, 10.01676f);
    collider.size = new Vector3(2.20023799f, 2.04105639f, 2.11126399f);
    }
    private void CreateBuilding9(){


    int buildingLengthSize = 1; 
    int buildingHeightSize = 1; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject building = new GameObject();
    building.name = "Building9";
    building.transform.parent = this.transform;
    building.AddComponent<Wall>();
    building.GetComponent<Wall>().initialiseWall(buildingLengthSize, buildingHeightSize, initialisePosition);
    
    //-160 - -170
    building.transform.localPosition = new Vector3(264f, 29f, Random.Range(-160f, -170f));
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    BoxCollider collider = building.AddComponent<BoxCollider>();
    collider.center = new Vector3(0f, -0.01442289f, 10.01676f);
    collider.size = new Vector3(2.20023799f, 2.04105639f, 2.11126399f);
    }
    private void CreateBuilding10(){


    int buildingLengthSize = 1; 
    int buildingHeightSize = 1; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject building = new GameObject();
    building.name = "Building10";
    building.transform.parent = this.transform;
    building.AddComponent<Wall>();
    building.GetComponent<Wall>().initialiseWall(buildingLengthSize, buildingHeightSize, initialisePosition);
    
    //-21 - 10
    building.transform.localPosition = new Vector3(264f, 29f, Random.Range(-21f, 10f));
    building.transform.localScale = new Vector3(10f, 40f, 10f);
    BoxCollider collider = building.AddComponent<BoxCollider>();
    collider.center = new Vector3(0f, -0.01442289f, 10.01676f);
    collider.size = new Vector3(2.20023799f, 2.04105639f, 2.11126399f);
    }
}
