using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShipScript : MonoBehaviour {
    public float xVal, yVal, zVal;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(xVal, yVal, zVal) * Time.deltaTime);
	}
}
