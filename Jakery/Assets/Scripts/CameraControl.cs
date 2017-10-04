using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
  private float speed = 75f;
  private int rotationSpeed = 100;

	// Update is called once per frame
	void Update () {
    // Camera rotation
    if (Input.GetKey(KeyCode.Q)){
      transform.Rotate(Vector3.up, Time.deltaTime*rotationSpeed);
    }
    if (Input.GetKey(KeyCode.E)){
      transform.Rotate(Vector3.up, -Time.deltaTime*rotationSpeed);
    }
		if (Input.GetKey(KeyCode.W)){
			transform.Translate(0,0,speed * Time.deltaTime);
			Debug.Log (speed + " " + Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A)){
			transform.Translate(Vector3.left * Time.deltaTime * speed);
		}		
		if (Input.GetKey(KeyCode.S)){
			transform.Translate(Vector3.back * Time.deltaTime * speed);
		}		
		if (Input.GetKey(KeyCode.D)){
			transform.Translate(Vector3.right * Time.deltaTime * speed);
		}
  }
 
}
