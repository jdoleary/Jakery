 // MoveToClickPoint.cs
    using UnityEngine;
    
    public class MoveToClickPoint : MonoBehaviour {
        UnityEngine.AI.NavMeshAgent agent;
	public GameObject Anim_Standing;
	public GameObject Anim_Walking;
        void Start() {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		Anim_Standing.SetActive (true);
		Anim_Walking.SetActive (false);
        }
        
        void Update() {
		// When unit arrives at destination:
		if(agent.remainingDistance <= float.Epsilon)
		{
			Anim_Standing.SetActive (true);
			Anim_Walking.SetActive (false);
			Debug.Log("Arrived");
		}
          // Raycast to click
          if (Input.GetMouseButtonDown(0)) {
              Debug.Log("mouse down");
              RaycastHit hit;
              
              if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) {
                  Debug.Log("hit " + hit.transform.gameObject);
                  agent.destination = hit.point;
				Anim_Standing.SetActive (false);
				Anim_Walking.SetActive (true);
              }
          }
        
        }
    }