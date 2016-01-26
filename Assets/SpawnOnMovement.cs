using UnityEngine;
using System.Collections;

public class SpawnOnMovement : MonoBehaviour {

    public GameObject prefabToSpawn = null;
    public float rangeToSpawn = 3;
    Vector3 startingPosition;
	// Use this for initialization
	void Start () {
        startingPosition = transform.parent.position;//set the initial starting postion to the begining coordinates
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > (startingPosition.x + rangeToSpawn))//if movement is past the designated x axis range, make a new object
        {
            GameObject newObject = GameObject.Instantiate(prefabToSpawn) as GameObject;
            newObject.transform.SetParent(this.transform);//make the new object's parent the current child
            startingPosition = transform.position;//set the new starting position to the current position
        }
        if (transform.position.y > (startingPosition.y + rangeToSpawn))//if movement is past the designated y axis range, make a new object
        {
            GameObject newObject = GameObject.Instantiate(prefabToSpawn) as GameObject;
            newObject.transform.SetParent(this.transform);//make the new object's parent the current child
            startingPosition = transform.position;//set the new starting position to the current position
        }
	}
}
