using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour {
  private Transform cam;
  private Transform player;
  private Renderer rend;
  public bool isSmall;
	// Use this for initialization
	void Start () {
		cam = Camera.main.gameObject.GetComponent<Transform>();
    player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
    rend.enabled = true;
    if(isSmall && ((cam.position.z < transform.position.z && transform.position.z < player.position.z) || (player.position.z < transform.position.z && transform.position.z < cam.position.z))){
      rend.enabled = false;
    }
    if(!isSmall && ((cam.position.x < transform.position.x && transform.position.x < player.position.x) || (player.position.x < transform.position.x && transform.position.x < cam.position.x))){
      rend.enabled = false;
    }
	}
}
