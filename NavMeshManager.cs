using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NavMeshManager : MonoBehaviour {
    public NavMeshSurface[] surfaces;
	// Use this for initialization
	void Start () {
        foreach (NavMeshSurface surface in surfaces)
        {
            surface.BuildNavMesh();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
