using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centerOnObject : MonoBehaviour {

    public Camera c;
    public GameObject obj;
    public Vector3 offset;// = new Vector3(1,2.5,-4);
	// Use this for initialization
	void Start () {
		offset = new Vector3(1, 4f, -12.5f);
       
    }
	
	// Update is called once per frame
	void Update ()
    {

        c.transform.LookAt(obj.transform.position);
        c.transform.position = obj.transform.position + offset;
	}
}
