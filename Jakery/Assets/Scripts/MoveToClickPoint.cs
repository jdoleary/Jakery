 // MoveToClickPoint.cs
    using UnityEngine;
    
    public class MoveToClickPoint : MonoBehaviour {
        UnityEngine.AI.NavMeshAgent agent;
        
        void Start() {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }
        
        void Update() {
          // Raycast to click
          if (Input.GetMouseButtonDown(0)) {
              Debug.Log("mouse down");
              RaycastHit hit;
              
              if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) {
                  Debug.Log("hit " + hit.transform.gameObject);
                  agent.destination = hit.point;
              }
          }
          // When unit arrives at destination:
          if(agent.remainingDistance <= float.Epsilon)
          {
            //Debug.Log("Arrived");
          }
        }
    }