﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMove : MonoBehaviour
{
    public float speed;
    public GameObject enemiesItem;
    GoldPooler goldPooler;
    EnemiesPooler enemiesPooler;
    private void Start()
    {
        enemiesPooler = EnemiesPooler.Instance;
        goldPooler = GoldPooler.Instance;

        // Initialize position for all things
        impactPositionThings();
    }

    public void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "PointEffect")
        {
            Vector3 pos = this.transform.position;

            pos.x = 4.0f;
            pos.y = UnityEngine.Random.Range(3.0f, 6.0f);
            this.transform.position = pos;

            impactPositionThings();
        }
    }

    void impactPositionThings()
    {
        for (int i = 0; i < this.transform.childCount - 1; i++)
        {
            if (this.transform.GetChild(i).transform.name == "BackgroundLine")
            {
                float scaleHorizontal = UnityEngine.Random.Range(0.55f, 0.75f);
                this.transform.GetChild(i).transform.localScale = new Vector3(scaleHorizontal, 1, 1);
                Vector3 posBackgroundLine = this.transform.GetChild(i).transform.position;
                Vector3 posGold = posBackgroundLine;
                initializeGolds(posGold, posBackgroundLine);

                initializeEnemies(posBackgroundLine);
            }
        }
    }

    void initializeGolds(Vector3 posGold, Vector3 posBackgroundLine)
    {
        posGold.y = posBackgroundLine.y + 0.7f;
        int[] hasGolds = { 0, 1, 2 };
        int hasGold = UnityEngine.Random.Range(0, 4);
        if (Array.IndexOf(hasGolds, hasGold) > -1)
        {
            int resultGold = UnityEngine.Random.Range(5, 11);
            for (int numberGold = 0; numberGold < resultGold; numberGold++)
            {
                posGold.x = UnityEngine.Random.Range(4.8f, 11.0f);
                goldPooler.SpawnFromPool("Gold", posGold, Quaternion.identity);
            }
        }
    }

    void initializeEnemies(Vector3 posBackgroundLine)
    {
        posBackgroundLine.y += 0.7f;
        float forEnemyPosX = UnityEngine.Random.Range(1.0f, 3.0f);
        posBackgroundLine.x -= forEnemyPosX;
        int[] hasEnemies = { 0, 1, 2, 3 };
        int hasEnemy = UnityEngine.Random.Range(0, 5);
        if (Array.IndexOf(hasEnemies, hasEnemy) > -1)
        {
            enemiesPooler.SpawnFromPool("Enemy", posBackgroundLine, Quaternion.identity);
        }
    }
}
