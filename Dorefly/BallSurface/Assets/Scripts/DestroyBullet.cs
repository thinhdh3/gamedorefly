﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
	public float aliveTime;
	// Use this for initialization
	void Start()
	{
		Destroy(gameObject, aliveTime);
	}
}
