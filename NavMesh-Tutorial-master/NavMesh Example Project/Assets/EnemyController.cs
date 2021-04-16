using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;
public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent enemyagent;
    public Transform player;

    public ThirdPersonCharacter character;


    void Start()
    {
        enemyagent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        enemyagent.destination = player.position;

        if(enemyagent.remainingDistance > enemyagent.stoppingDistance)
        {
            character.Move(enemyagent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero,false,false);
        }
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            GameManagerScript.lives -= 1;
            Destroy(collider.gameObject);
            
            SceneManager.LoadScene("Example01 - Basics");
        }
    }
}
