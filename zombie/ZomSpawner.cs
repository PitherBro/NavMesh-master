using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZomSpawner : MonoBehaviour {
    public NavMeshAgent ZomPrefab;
    public Transform Location;

    public Zom SpawnZom()
    {
        ZomPrefab.transform.localPosition = Location.localPosition;
        return new Zom();
    }
	
}
