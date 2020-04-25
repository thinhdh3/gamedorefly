using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
	public float bulletspeed;
	Rigidbody2D myrigi;
	// Use this for initialization

	void Awake()
	{
		myrigi = GetComponent<Rigidbody2D>();
		if (transform.localRotation.z > 0)
		{
			myrigi.AddForce(new Vector2(-1, 0) * bulletspeed, ForceMode2D.Impulse);
		}
		else myrigi.AddForce(new Vector2(1, 0) * bulletspeed, ForceMode2D.Impulse);
	}
	
	//future is work Bullet stop.
	public void removeForce()
	{
		myrigi.velocity = new Vector2(0, 0);
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Enemy")
		{
			gameObject.SetActive(false);
		}
	}
}
