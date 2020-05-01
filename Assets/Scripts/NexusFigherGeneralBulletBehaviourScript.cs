using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NexusFigherGeneralBulletBehaviourScript : MonoBehaviour
{
    public NavMeshAgent agent;
    private GameObject motherShipGameObject;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        motherShipGameObject = GameObject.Find("HumanMotherShip");
        agent.destination = motherShipGameObject.transform.position;
    }
}
