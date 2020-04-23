using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;

    public void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
