using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadLevel2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateRoad();
        CreateRoad2();
        CreateRoad3();
        CreateRoad4();
        CreateRoad5();
    }

    private void CreateRoad() {

        int roadLengthSize = 10;
        int roadHeightSize = 10;
        Vector3 initialisePosition = new Vector3(0,0,10f);

        GameObject road = new GameObject();
        road.name = "Road";
        road.transform.parent = this.transform;
        road.AddComponent<Wall>();
        road.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);
        
        road.transform.localPosition = new Vector3(0, 0, 50f);
        road.transform.Rotate(90, 0, 0, Space.Self);
        road.transform.localScale = new Vector3(15f, 1f, 1f);
        BoxCollider collider = road.AddComponent<BoxCollider>();
        collider.center = new Vector3(9.022366f, 9.022366f, 11f);
        collider.size = new Vector3(20.25608f, 21.9303f, 3.985396f);

        GameObject whiteline = new GameObject();
        whiteline.name = "WhiteLine";
        whiteline.transform.parent = this.transform;
        whiteline.AddComponent<Wall>();
        whiteline.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);

        whiteline.transform.localPosition = new Vector3(0f, -9f, 70f);
        whiteline.transform.Rotate(180, 0, 0, Space.Self);
        whiteline.transform.localScale = new Vector3(15f, 0.100000001f, 1f);
    }
    private void CreateRoad2() {

        int roadLengthSize = 10;
        int roadHeightSize = 10;
        Vector3 initialisePosition = new Vector3(0,0,10f);

        GameObject road = new GameObject();
        road.name = "Road2";
        road.transform.parent = this.transform;
        road.AddComponent<Wall>();
        road.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);
        
        road.transform.localPosition = new Vector3(0, 0, -50f);
        road.transform.Rotate(90, 0, 0, Space.Self);
        road.transform.localScale = new Vector3(15f, 1f, 1f);
        BoxCollider collider = road.AddComponent<BoxCollider>();
        collider.center = new Vector3(9.022366f, 9.022366f, 11f);
        collider.size = new Vector3(20.25608f, 21.9303f, 3.985396f);

        GameObject whiteline = new GameObject();
        whiteline.name = "WhiteLine2";
        whiteline.transform.parent = this.transform;
        whiteline.AddComponent<Wall>();
        whiteline.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);

        whiteline.transform.localPosition = new Vector3(0f, -9f, -31f);
        whiteline.transform.Rotate(180, 0, 0, Space.Self);
        whiteline.transform.localScale = new Vector3(15f, 0.100000001f, 1f);
    }
    private void CreateRoad3() {

        int roadLengthSize = 10;
        int roadHeightSize = 10;
        Vector3 initialisePosition = new Vector3(0,0,10f);

        GameObject road = new GameObject();
        road.name = "Road3";
        road.transform.parent = this.transform;
        road.AddComponent<Wall>();
        road.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);
        
        road.transform.localPosition = new Vector3(25f, 0, 110f);
        road.transform.Rotate(90, 90, 0, Space.Self);
        road.transform.localScale = new Vector3(10f, 1f, 1f);
        BoxCollider collider = road.AddComponent<BoxCollider>();
        collider.center = new Vector3(9.022366f, 9.022366f, 11f);
        collider.size = new Vector3(20.25608f, 21.9303f, 3.985396f);

        GameObject whiteline = new GameObject();
        whiteline.name = "WhiteLine3";
        whiteline.transform.parent = this.transform;
        whiteline.AddComponent<Wall>();
        whiteline.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);

        whiteline.transform.localPosition = new Vector3(129f, -9f, -70f);
        whiteline.transform.Rotate(0, 90, 180, Space.Self);
        whiteline.transform.localScale = new Vector3(10f, 0.100000001f, 1f);
    }
    private void CreateRoad4() {

        int roadLengthSize = 10;
        int roadHeightSize = 10;
        Vector3 initialisePosition = new Vector3(0,0,10f);

        GameObject road = new GameObject();
        road.name = "Road4";
        road.transform.parent = this.transform;
        road.AddComponent<Wall>();
        road.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);
        
        road.transform.localPosition = new Vector3(235f, 0, 110f);
        road.transform.Rotate(90, 90, 0, Space.Self);
        road.transform.localScale = new Vector3(10f, 1f, 1f);
        BoxCollider collider = road.AddComponent<BoxCollider>();
        collider.center = new Vector3(9.022366f, 9.022366f, 11f);
        collider.size = new Vector3(20.25608f, 21.9303f, 3.985396f);

        GameObject whiteline = new GameObject();
        whiteline.name = "WhiteLine4";
        whiteline.transform.parent = this.transform;
        whiteline.AddComponent<Wall>();
        whiteline.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);

        whiteline.transform.localPosition = new Vector3(235f, -9f, -70f);
        whiteline.transform.Rotate(0, 90, 180, Space.Self);
        whiteline.transform.localScale = new Vector3(10f, 0.100000001f, 1f);
    }
    private void CreateRoad5() {

        int roadLengthSize = 10;
        int roadHeightSize = 10;
        Vector3 initialisePosition = new Vector3(0,0,10f);

        GameObject road = new GameObject();
        road.name = "Road5";
        road.transform.parent = this.transform;
        road.AddComponent<Wall>();
        road.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);
        
        road.transform.localPosition = new Vector3(130f, 0, 110f);
        road.transform.Rotate(90, 90, 0, Space.Self);
        road.transform.localScale = new Vector3(10f, 1f, 1f);
        BoxCollider collider = road.AddComponent<BoxCollider>();
        collider.center = new Vector3(9.022366f, 9.022366f, 11f);
        collider.size = new Vector3(20.25608f, 21.9303f, 3.985396f);

        GameObject whiteline = new GameObject();
        whiteline.name = "WhiteLine5";
        whiteline.transform.parent = this.transform;
        whiteline.AddComponent<Wall>();
        whiteline.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);

        whiteline.transform.localPosition = new Vector3(44f, -9f, 110f);
        whiteline.transform.Rotate(0, -90, 180, Space.Self);
        whiteline.transform.localScale = new Vector3(10f, 0.100000001f, 1f);
    }
}
