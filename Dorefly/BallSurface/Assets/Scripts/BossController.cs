using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BossController : MonoBehaviour
{
    private SpriteRenderer rend;
    int savePriority = 0;
    public void orderLayerForBoss(int priority)
    {
        if (this.gameObject.GetComponent<SpriteRenderer>())
        {
            rend = this.gameObject.GetComponent<SpriteRenderer>();
            //BoxCollider2D boxBoss = this.gameObject.GetComponent<BoxCollider2D>();
            rend.sortingOrder = priority;
            savePriority = priority;
            if (priority == 2)
            {
                //boxBoss.isTrigger = true;
                this.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            }
            else
            {
                //boxBoss.isTrigger = false;
                this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Bullet" && savePriority == 2)
        {
            gameObject.SetActive(false);
        }
    }
}
