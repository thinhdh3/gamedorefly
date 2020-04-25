using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBulletController : MonoBehaviour
{
    public Transform Guntip;
    public GameObject bullet;
    public GameObject bossCastle;
    public Text mainScore;
    float nextFire = 0;
    float fireRate = 0.5f;
    bool facingRight;
    void Start()
    {
        facingRight = true;
    }

    public void fireBullet()
    {
        int score = int.Parse(mainScore.text);
        int realScore = 0;
        if (score >= 10 && Guntip)
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                if (facingRight)
                {
                    Instantiate(bullet, Guntip.position, Quaternion.Euler(new Vector3(0, 0, 0)));
                }
                else if (!facingRight)
                {
                    Instantiate(bullet, Guntip.position, Quaternion.Euler(new Vector3(0, 0, 180)));
                }
            }
            realScore = score - 10;
            mainScore.text = realScore.ToString();
        } else if(realScore < 100)
        {
            BossController bossHandle = bossCastle.gameObject.GetComponent<BossController>();
            bossHandle.orderLayerForBoss(1);
        }
    }
}
