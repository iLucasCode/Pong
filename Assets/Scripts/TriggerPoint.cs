using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour
{

	public Collider2D collision;

	void Start()
	{

		collision = GetComponent<Collider2D>();

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		switch(gameObject.name)
        {

			case "BlueSite":
					if (collision.gameObject.name == "Ball")
					{
						Debug.Log(collision.gameObject.name);
						ScoreCountRed.scoreValue += 1;

					}
				
				break;

			case "RedSite":
				if (collision.gameObject.name == "Ball")
				{
					Debug.Log(collision.gameObject.name);
					ScoreCountBlue.scoreValue += 1;

				}
				break;

			default:
				break;
		}

	}

}
