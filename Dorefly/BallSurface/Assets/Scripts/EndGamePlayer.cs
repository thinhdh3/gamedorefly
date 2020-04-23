using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGamePlayer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player2DExample playerdie = other.gameObject.GetComponent<Player2DExample>();
            playerdie.makeDeadplayer();
        }
    }
}
