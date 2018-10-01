using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctahedronSphereCreator {

    public static Mesh Create (int subdivisions, float radius) {

        Vector3[] vertices = {
            Vector3.down,
            Vector3.forward,
            Vector3.left,
            Vector3.back,
            Vector3.right,
            Vector3.up

        };

        int[] triangles = {
            0, 1, 2,
            0, 2, 3,
            0, 3, 4,
            0, 4, 1,

            5, 2, 1,
            5, 3, 2, 
            5, 4, 3,
            5, 1, 4,
        };

        if (radius != 1f) {
            for (int i = 0; i < vertices.Length; i++) {
                vertices[i] *= radius;
            }
        }

        Mesh mesh = new Mesh();
        mesh.name = "Octahedron Sphere";
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        return mesh;

    }
    
}
