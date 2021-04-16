using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;

    public NavMeshAgent navmeshAgent;
    public ThirdPersonCharacter character;

    void Start()
    {
        navmeshAgent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                navmeshAgent.SetDestination(hit.point);
            }

            
        }

        if(navmeshAgent.remainingDistance > navmeshAgent.stoppingDistance)
        {
            character.Move(navmeshAgent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero,false,false);
        }
        
    }

    
}
