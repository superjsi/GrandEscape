using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class MothershipBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject motherShipGameObject;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        motherShipGameObject = GameObject.Find("MotherShip");
    }

    // Update is called once per frame
    void Update()
    {
        var fighter = GameObject.Find("Fighter");
        var distanceFromFighter = Vector3.Distance(fighter.transform.position, motherShipGameObject.transform.position);

        agent.speed = distanceFromFighter * 0.1f;

        if (distanceFromFighter > 100)
            agent.speed = 0;

        agent.destination = Vector3.forward;

    }
}
