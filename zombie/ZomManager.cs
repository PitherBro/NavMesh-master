using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZomManager : MonoBehaviour
{

    //create class that can use new
    //in that class manipulate navmesh agent       
    public int maxZoms = 10;
    public float SpawnRate = 3;
    float timer = 0;
    int zomsOnScreen = 0;
    public List<string> zomIds = new List<string>();
    //public List<Zom> zoms = new List<Zom>();
    //public ZomSpawner zomSpawn;
    public GameObject meshAgent;
    public Transform location;
    private void Start()
    {
    }
    private void Update()
    {
        if(zomsOnScreen < 10)
            timer += Time.deltaTime;
        if (timer >= SpawnRate && zomsOnScreen < maxZoms)
        {
            timer = 0;
            SpawnZom();
            zomsOnScreen++;
        }
        foreach (char letter in Input.inputString)
        {
            if (letter == 'd')
            {
                destroyRandomZom();
            }
        }

    }
    void SpawnZom()
    {
        //NavMeshGround
        Vector3 t = GameObject.Find("Ground").transform.localPosition;
       // t.x = 0;
        //t.z = 0;
        meshAgent.transform.localPosition = location.localPosition;
        Zom clone = new Zom();
        clone.self = Instantiate(meshAgent);
        clone.self.transform.localPosition = Vector3.zero;

        clone.self.name = "Zom: " + clone.self.GetInstanceID();
        zomIds.Add(clone.self.name);
       // zoms.Add(clone);

    }
    void destroyRandomZom()
    {
        int x = Random.Range(0, zomIds.Count - 1);
        Destroy(GameObject.Find(zomIds[x]));
        zomIds.Remove(zomIds[x]);
        zomsOnScreen--;
    }
}

