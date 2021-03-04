using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StupidAIMovement : MonoBehaviour {

	public float speed = 3;
	public Transform pathStart;
	public Transform pathEnd;
	
	public Rigidbody2D rigidbody;

	public Transform currentTarget;

	public void FixedUpdate() {
		if (!currentTarget) currentTarget = pathStart;
		
		rigidbody.MovePosition(Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime));

		if (currentTarget.position == transform.position) currentTarget = currentTarget == pathStart ? pathEnd : pathStart;
	}
}
