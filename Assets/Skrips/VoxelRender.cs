using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]

public class VoxelRender : MonoBehaviour
{
    Mesh mesh;
    public float scale = 1f;
    float adjScale;
    List<Vector3> vertices;
    List<int> triangles;
    private void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        adjScale = scale * 0.5f;
    }

    void Start()
    {
        GenerateVoxelMesh(new VoxelData());
        UpdateMesh();
    }

    void UpdateMesh()
    {

    }

    void GenerateVoxelMesh(VoxelData data)
    {

    }

    void MakeFace(int dir, float cubeSkale)
    {
        vertices.AddRange(CubeMeshData.FaceVertices(dir, cubeSkale));
        int vCount = vertices.Count;

        triangles.Add(vCount - 4);
        triangles.Add(vCount - 3);
        triangles.Add(vCount - 2);
        triangles.Add(vCount - 4);
        triangles.Add(vCount - 2);
        triangles.Add(vCount - 1);
    }

}
