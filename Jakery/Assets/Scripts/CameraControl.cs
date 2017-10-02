using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
  public Transform around;
  public Transform followTarget;
  public float speed = 5f;
  private int rotationSpeed = 100;

	// Update is called once per frame
	void Update () {
    float step = speed * Time.deltaTime;
    transform.position = Vector3.MoveTowards(transform.position, followTarget.position, step);
    // Camera rotation
    if (Input.GetKey(KeyCode.Q)){
      transform.RotateAround(around.position, Vector3.up, Time.deltaTime*rotationSpeed);
    }
    if (Input.GetKey(KeyCode.E)){
      transform.RotateAround(around.position, Vector3.up, -Time.deltaTime*rotationSpeed);
    }


  }
 
}
