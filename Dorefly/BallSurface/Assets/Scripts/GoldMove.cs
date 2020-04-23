using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldMove : MonoBehaviour
{
    Vector3 pos;
    Text totalGold;
    public float speed;
    private void Start()
    {
        totalGold = GameObject.Find("TotalGold").GetComponent<Text>();
    }
    public void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            int score = int.Parse(totalGold.text);
            totalGold.text = (score + 100).ToString();
        }
    }
}
