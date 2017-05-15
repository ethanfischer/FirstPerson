using UnityEngine;
using System.Collections;

namespace Chapter1
{
	public class Spawner : MonoBehaviour {

    public int numberOfEnemies;
	public float spawnRadius = 5;
	public GameObject objectToSpawn;
	private Vector3 spawnPosition;
	private GameManager_EventMaster eventMasterScript;
	
	void OnEnable()
	{
	    SetInitialReferences();
		eventMasterScript.myGeneralEvent += SpawnObject;	
	}
	
	void OnDisable()
	{
	    eventMasterScript.myGeneralEvent -= SpawnObject;		
	}
	// // Update is called once per frame
	// void Update () {
	
	// }
	
	void SpawnObject() 
	{
		for (int i = 0; i < numberOfEnemies; i++)
		{
			spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
			Vector3 adjustedPos = new Vector3(spawnPosition.x, 1, spawnPosition.z);
			Instantiate(objectToSpawn,adjustedPos, Quaternion.identity);;
		}
	}
	
	void SetInitialReferences()
	{
		eventMasterScript = GameObject.Find("GameManager").GetComponent<GameManager_EventMaster>();
		
	}
}

}
