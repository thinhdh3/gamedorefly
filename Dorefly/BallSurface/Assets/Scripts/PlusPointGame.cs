using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusPointGame : MonoBehaviour
{
    public Text scoreMain;
    // Start is called before the first frame update
    void Start()
    {
        scoreMain.text = (00000).ToString();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            int score = int.Parse(scoreMain.text);
            scoreMain.text = (score + 10).ToString();
        }
    }
}
