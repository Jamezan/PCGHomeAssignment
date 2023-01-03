using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class PyramidBuilder : MonoBehaviour
{

    [SerializeField]
    private float pyramidSize = 6f;

    [SerializeField]
    private int baseSubMeshIndex = 0;
    [SerializeField]
    private int triangle1MeshIndex = 1;
    [SerializeField]
    private int triangle2MeshIndex = 2;
    [SerializeField]
    private int triangle3MeshIndex = 3;


    private int subMeshSize = 4;

    // Start is called before the first frame update
    void Start()
    {
        CreatePyramid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void CreatePyramid(){

        MeshFilter meshFilter = this.GetComponent<MeshFilter>();

        MeshBuilder meshBuilder = new MeshBuilder(subMeshSize);

        //Add Pyramid Points

        Vector3 topPoint = new Vector3(0, pyramidSize, 0);

        Vector3 bottomPoint1 = new Vector3(0, 0, -pyramidSize);

        Vector3 bottomPoint2 = new Vector3(-pyramidSize, 0 , pyramidSize);

        Vector3 bottomPoint3 = new Vector3(pyramidSize , 0 , pyramidSize);

        //Create the triangles

        meshBuilder.TriangleBuilder(bottomPoint1, bottomPoint3, bottomPoint2, baseSubMeshIndex);

        meshBuilder.TriangleBuilder(bottomPoint3, bottomPoint1, topPoint, triangle1MeshIndex);

        meshBuilder.TriangleBuilder(bottomPoint2, topPoint, bottomPoint1, triangle2MeshIndex);

        meshBuilder.TriangleBuilder(bottomPoint2, bottomPoint3, topPoint, triangle3MeshIndex);

        meshFilter.mesh = meshBuilder.CreateMesh();

        MeshRenderer meshRenderer = this.GetComponent<MeshRenderer>();

        MaterialsBuilder materialsBuilder = new MaterialsBuilder();

        meshRenderer.materials = materialsBuilder.MaterialsList().ToArray();

    }
}
