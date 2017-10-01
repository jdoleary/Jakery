using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
 public Transform around;
 public Transform followTarget;
 public float speed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.RotateAround(around.position, Vector3.up, 20 * Time.deltaTime);
    float step = speed * Time.deltaTime;
    transform.position = Vector3.MoveTowards(transform.position, followTarget.position, step);
    if (Input.GetKeyDown("up")){
      transform.RotateAround(around.position, Vector3.up, 90);
    }

  }
}
