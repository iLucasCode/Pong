using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	
	public float speed = 0.015f;
	private Vector2 currentPosition;
	public static Vector2 startPosition;



	
	void Update () {

		Debug.Log(gameObject.name);
		currentPosition = this.transform.position;

		switch (gameObject.name)
		{

			case "BluePlayer":
				currentPosition = this.transform.position;
				if (Input.GetKey(KeyCode.RightArrow) && currentPosition.x < 8f)
				{

					transform.position += transform.right * speed;

				}
				else if (Input.GetKey(KeyCode.LeftArrow) && currentPosition.x > -8f)
				{
					transform.position += transform.right * -speed;

				}
				break;

			case "RedPlayer":

				currentPosition = this.transform.position;

				if (Input.GetKey(KeyCode.D) && currentPosition.x < 8f)
				{
					transform.position += transform.right * speed;
				}
				else if (Input.GetKey(KeyCode.A) && currentPosition.x > -8f)
				{
					transform.position += transform.right * -speed; ;
				}
				break;

			default:
				break;

		}

	}

}


