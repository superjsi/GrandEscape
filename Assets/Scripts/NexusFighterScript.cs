using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NexusFighterScript : MonoBehaviour
{
    public NavMeshAgent agent;
    private GameObject motherShipGameObject;
    public GameObject nexusFighterBulletPrefab;
    public int nexusFighterIndex;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        motherShipGameObject = GameObject.Find("HumanMotherShip");
        agent.destination = motherShipGameObject.transform.position;
        agent.speed = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        motherShipGameObject = GameObject.Find("HumanMotherShip");

        var fighter = GameObject.Find(string.Format("NexusFighter{0}", nexusFighterIndex));
        var distanceFromHumanMotherShip = Vector3.Distance(fighter.transform.position, motherShipGameObject.transform.position);
        Debug.Log(string.Format("NexusFighter distance {0}", distanceFromHumanMotherShip));
        if(distanceFromHumanMotherShip < 300)
        {
            agent.destination = fighter.transform.position;
            var position =  new Vector3(fighter.transform.position.x, -200, fighter.transform.position.z);
            var bullet = Instantiate(nexusFighterBulletPrefab, position, nexusFighterBulletPrefab.transform.rotation) as GameObject;
            bullet.transform.position.Set(fighter.transform.position.x, fighter.transform.position.y, fighter.transform.position.z + 10);
        }
        else 
        {
            agent.destination = motherShipGameObject.transform.position;
        }
    }
}
