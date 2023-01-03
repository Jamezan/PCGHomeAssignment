using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateRoad();
        CreateRoad1();
        CreateRoad2();
    }

    private void CreateRoad() {

        int roadLengthSize = 10;
        int roadHeightSize = 10;
        Vector3 initialisePosition = new Vector3(0,0,10f);

        GameObject road = new GameObject();
        road.name = "MainRoad";
        road.transform.parent = this.transform;
        road.AddComponent<Wall>();
        road.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);
        
        road.transform.position = new Vector3(0, 0, 0);
        road.transform.Rotate(90, 0, 0, Space.Self);
        road.transform.localScale = new Vector3(10f, 1f, 1f);
    }
    private void CreateRoad1() {

        int roadLengthSize = 10;
        int roadHeightSize = 10;
        Vector3 initialisePosition = new Vector3(0,0,10f);

        GameObject road = new GameObject();
        road.name = "SideRoad1";
        road.transform.parent = this.transform;
        road.AddComponent<Wall>();
        road.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);
        
        road.transform.position = new Vector3(30f, 0, 100f);
        road.transform.Rotate(90, 90, 0, Space.Self);
        road.transform.localScale = new Vector3(10f, 1f, 1f);
    }
    private void CreateRoad2() {

        int roadLengthSize = 10;
        int roadHeightSize = 10;
        Vector3 initialisePosition = new Vector3(0,0,10f);

        GameObject road = new GameObject();
        road.name = "SideRoad2";
        road.transform.parent = this.transform;
        road.AddComponent<Wall>();
        road.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);
        
        road.transform.position = new Vector3(140f, 0, 100f);
        road.transform.Rotate(90, 90, 0, Space.Self);
        road.transform.localScale = new Vector3(10f, 1f, 1f);
    }
}
