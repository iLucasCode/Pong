using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

	public static float speed = 5.1f;
	private Vector2 direction = new Vector2();
	private new Rigidbody2D rigidbody;


	public Collider2D collision;

	private Vector2 startPosition;



	void Start()
	{

		startPosition = this.transform.position;
		rigidbody = GetComponent<Rigidbody2D>();

		direction = Random.insideUnitCircle.normalized;

		Debug.Log(direction.x);
		Debug.Log(direction.y);

		collision = GetComponent<Collider2D>();



		if (direction.x >= 0f && direction.x <= 0.2f)
		{
			direction.x = direction.x + 0.3f;
		}
		else if (direction.x <= 0f && direction.x >= -0.3f)
		{
			direction.x = direction.x - 0.3f;
		}
		if (direction.y >= 0f && direction.y <= 0.3f)
		{
			direction.y = direction.y + 0.3f;
		}
		else if (direction.y <= 0f && direction.y >= -0.3f)
		{
			direction.y = direction.y - 0.3f;
		}


		rigidbody.velocity = new Vector2((direction.x *  speed), (direction.y *  speed));


	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.name == "BlueSite")
		{
			//Debug.Log(collision.gameObject.name);
			
			this.transform.position = startPosition;
			Start();


		}
		else if (collision.gameObject.name == "RedSite")
		{
			//Debug.Log(collision.gameObject.name);
			
			this.transform.position = startPosition;
			Start();
		}
	}

	void Update()
	{
		Vector2 currentSpeed = rigidbody.velocity;
		Debug.Log(currentSpeed);
	}

}

