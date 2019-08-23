using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour {

	public float rotateSpeed = 20f;

	private Vector3 targetPosition;
	private bool isMoving;


	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			isMoving = true;
			SetTargetPosition();
		}

		if (isMoving)
			MovePlayer();
	}

	private void MovePlayer ()
	{
		Quaternion targetRotation = Quaternion.LookRotation(targetPosition - transform.position);

		//transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
		//transform.position = Vector3.MoveTowards(transform.position, targetPosition, walkSpeed * Time.deltaTime);

		transform.rotation =  Quaternion.Euler (targetRotation.x, targetRotation.y, targetRotation.z);
		transform.position = new Vector3 (targetPosition.x, targetPosition.y, targetPosition.z);

		if (transform.position == targetPosition)
			isMoving = false;
	}

	private void SetTargetPosition ()
	{
		Plane playerPlane = new Plane(Vector3.up, transform.position);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		float hitdist = 0.0f;

		if (playerPlane.Raycast(ray, out hitdist))
			targetPosition = ray.GetPoint(hitdist);
	}
}
