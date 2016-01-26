using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {
    //Value given from editor;
    public GameObject prefabToSpawn = null;
	// Use this for initialization
	void Start () {
        GameObject spawnedObject = GameObject.Instantiate(prefabToSpawn) as GameObject;
        spawnedObject.name = "Justice League";
        spawnedObject.transform.parent = transform;
        //Setting ourselves to be the Parent
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
