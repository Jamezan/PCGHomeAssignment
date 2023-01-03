using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateFrontWall();
    }

    private void CreateFrontWall(){


    int wallLengthSize = 10; 
    int wallHeightSize = 5; 
    Vector3 initialisePosition = new Vector3(0,0,10f);

    GameObject wall = new GameObject();
    wall.name = "Wall";
    wall.transform.parent = this.transform;
    wall.AddComponent<Wall>();
    wall.GetComponent<Wall>().initialiseWall(wallLengthSize, wallHeightSize, initialisePosition);
    
    this.transform.position = new Vector3(0, 0, 8f);
    }
}
