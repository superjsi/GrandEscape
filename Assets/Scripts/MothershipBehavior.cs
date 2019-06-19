using UnityEngine;
using UnityEngine.AI;


public class MothershipBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject motherShipGameObject;
    private GameObject portalGameObject;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        motherShipGameObject = GameObject.Find("HumanMotherShip");
        portalGameObject = GameObject.Find("Portal");
        agent.destination = portalGameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var fighter = GameObject.Find("HumanFighter");

        var distanceFromFighter = Vector3.Distance(fighter.transform.position, motherShipGameObject.transform.position);
        agent.speed = distanceFromFighter * 0.1f;

        if (distanceFromFighter > 100)
            agent.speed = 0;
    }
}
