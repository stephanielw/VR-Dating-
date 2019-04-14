using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class PLAYER : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    public NavMeshAgent agent2;


    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        agent2.SetDestination(target.position);
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.collider.name =="Enemy 1")
        {
            SceneManager.LoadScene(0);

        }
    }
}
