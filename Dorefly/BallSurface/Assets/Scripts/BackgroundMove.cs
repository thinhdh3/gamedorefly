using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float speed;
    public int numBGPanels = 6;
    public GameObject backGroundNext;

    public void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "PointEffect")
        {
            Vector3 pos = this.transform.position;
            Vector3 posBG = backGroundNext.transform.position;
            pos.x = posBG.x + 17.9f;
            this.transform.position = pos;
        }
    }
}
