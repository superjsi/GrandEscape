using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployNexusFighter : MonoBehaviour
{
    public GameObject nexusFighterPrefab;
    public float respawnTime = 20.0f;
    public int nexusFighterIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nexusFighterWave());
    }

    private void spawnEnemy() 
    {
        GameObject fighter1 = Instantiate(nexusFighterPrefab) as GameObject;
        fighter1.transform.position = new Vector3(-10000, -200, -147);
        var nexusFighterScript = fighter1.GetComponent<NexusFighterScript>();
        nexusFighterScript.nexusFighterIndex = nexusFighterIndex;
        fighter1.name = string.Format("NexusFighter{0}", nexusFighterIndex);
        nexusFighterIndex++;

        GameObject fighter2 = Instantiate(nexusFighterPrefab) as GameObject;
        fighter2.transform.position = new Vector3(-10000, -200, -147);
        nexusFighterScript = fighter2.GetComponent<NexusFighterScript>();
        nexusFighterScript.nexusFighterIndex = nexusFighterIndex;
        fighter2.name = string.Format("NexusFighter{0}", nexusFighterIndex);
        nexusFighterIndex++;

        GameObject fighter3 = Instantiate(nexusFighterPrefab) as GameObject;
        fighter3.transform.position = new Vector3(-10000, -200, -147);
        nexusFighterScript = fighter3.GetComponent<NexusFighterScript>();
        nexusFighterScript.nexusFighterIndex = nexusFighterIndex;
        fighter3.name = string.Format("NexusFighter{0}", nexusFighterIndex);
        nexusFighterIndex++;
    }

    IEnumerator nexusFighterWave() 
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
