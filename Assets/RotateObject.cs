using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {
    public float rotateSpeed = 10f;
	// Use this for initialization
	void Start () {
  
	}
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,0,rotateSpeed * Time.deltaTime);//rotate the object at the user selected speed
	}
}
