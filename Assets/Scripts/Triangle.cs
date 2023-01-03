using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class Triangle : MonoBehaviour
{

    [SerializeField]
    private Vector3 size = Vector3.one;

    private int submeshCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        //CreateTriangle();
    }

    // Update is called once per frame
    void Update()
    {
        CreateTriangle();
    }


    private void CreateTriangle(){

        MeshFilter meshFilter = this.GetComponent<MeshFilter>();

        MeshBuilder meshBuilder = new MeshBuilder(submeshCount);

        Vector3 p0 = new Vector3(size.x, size.y, -size.z);
        Vector3 p1 = new Vector3(-size.x, size.y, -size.z);
        Vector3 p2 = new Vector3(-size.x, size.y, size.z);

        meshBuilder.TriangleBuilder(p0, p1, p2, 0);

        meshFilter.mesh = meshBuilder.CreateMesh();
    }

}
