using UnityEngine;
using System.Collections;

public class MoveSprite : MonoBehaviour {
    public float movementSpeed = 0.5f;
    public float maximumDistance = 3f;
    public int hitMaxX = 0;
	// Use this for initialization
	void Start () {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.localPosition;
        if (position.x <= 0)//if the child gets to the parent's coordinates, raise a flag
            hitMaxX = 0;
        if (position.x >= maximumDistance)//if you hit the maximum allowed distance, raise a flag
            hitMaxX = 1;
        if (hitMaxX == 1)
            position.x -= movementSpeed * Time.deltaTime;//get closer to the parent
        else
            position.x += movementSpeed * Time.deltaTime;//get further from the parent
        transform.localPosition = position;

	}
}
