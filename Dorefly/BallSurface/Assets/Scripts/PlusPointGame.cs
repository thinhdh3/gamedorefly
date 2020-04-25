using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusPointGame : MonoBehaviour
{
    public Text scoreMain;
    public Text bigScore;
    public GameObject bossCastle;
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
            int finalScore = score + 10;
            bigScore.text = (score + 1).ToString();
            scoreMain.text = finalScore.ToString();
            if (finalScore >= 100)
            {
                BossController bossHandle = bossCastle.gameObject.GetComponent<BossController>();
                bossHandle.orderLayerForBoss(2);
            }
        }
    }
}
