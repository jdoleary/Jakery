using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour {
  private Transform cam;
  private Transform player;
  private Renderer rend;
  
  private Material opaque;
  private Material faded;
  public bool isSmall;
  private bool wasHidden;
  private bool hide;
	// Use this for initialization
	void Start () {
		cam = Camera.main.gameObject.GetComponent<Transform>();
    player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    rend = GetComponent<Renderer>();
    opaque = Resources.Load("Materials/Wall") as Material;
    faded = Resources.Load("Materials/Wall Faded") as Material;
	}
	
	// Update is called once per frame
	void Update () {
    hide = false;
    if(isSmall && ((cam.position.z < transform.position.z && transform.position.z < player.position.z) || (player.position.z < transform.position.z && transform.position.z < cam.position.z))){
      hide = true;
    }
    if(!isSmall && ((cam.position.x < transform.position.x && transform.position.x < player.position.x) || (player.position.x < transform.position.x && transform.position.x < cam.position.x))){
      hide = true;
    }
    if(hide){
      rend.material = faded; 
      wasHidden = true;
    }else{
      if(wasHidden){
        rend.material = opaque; 
        wasHidden = false;
      }
      
    }
	}
}
