using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class mob : MonoBehaviour {
    public NavMeshAgent target;
    public NavMeshAgent self;
    public ThirdPersonCharacter character;
   
    private void Start()
    {
        target =  GameObject.Find("Player").GetComponent<NavMeshAgent>();
        self.updateRotation = false;
        self.transform.localPosition = GameObject.Find("Spawner").transform.localPosition;
        self.speed = randSpeed();
        
        
    }
    // Update is called once per frame
    void Update () {
        self.SetDestination(target.transform.localPosition);
        if (self.remainingDistance > self.stoppingDistance)
            character.Move(self.desiredVelocity, false, false);
        else
        {
            character.Move(Vector3.zero, false, false);
        }
    }
    float randSpeed()
    {
        float multiplyer = Random.Range(.5f, .85f);
        return target.speed * multiplyer;
    }
}
