﻿ // MoveToClickPoint.cs
    using UnityEngine;
    
    public class MoveToClickPoint : MonoBehaviour {
        UnityEngine.AI.NavMeshAgent agent;
        
        void Start() {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }
        
        void Update() {
            if (Input.GetMouseButtonDown(0)) {
                    Debug.Log("mouse down");
                RaycastHit hit;
                
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000)) {
                    agent.destination = hit.point;
                    Debug.Log(agent.destination);
                }
            }
        }
    }