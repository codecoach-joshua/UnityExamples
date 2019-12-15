using System.Collections;
using UnityEngine;

public class BasicAgentController : MonoBehaviour {

  //reference for the NavMeshAgent component used by this object
  private NavMeshAgent navAgent;
  
  //reference to the game object for the main player
  private GameObject player;

	// Use this for initialization
	void Start () {
    //load the component for the NavMeshAgent
    navAgent = GetComponent<NavMeshAgent>();
    
    //load game object for the main player by finding it based on the "Player" tag
	  player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
    // NavMeshAgent will automatically control its game object to move to its "destination"
    
    // have basic navAgent follow and chase the player
	  navAgent.destination = player.transform.position;      
	}
}
