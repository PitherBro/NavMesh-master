using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[System.Serializable]
public class Zom
{
    public GameObject self;
    public float speed =1;
    public Zom()
    {
        //adjustSpeed();
    }
    public void removeZom()
    {
        GameObject.Destroy(self);
      
    }
    public void adjustSpeed()
    {
        self.GetComponent<NavMeshAgent>().speed = speed;       
    }
}
