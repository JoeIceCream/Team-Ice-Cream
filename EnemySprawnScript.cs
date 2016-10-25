using System;
using UnityEngine;
using System.Collections;

public class EnemySprawnScript : MonoBehaviour
{
    private int countOfEnemyPerRound;
    private int roundNum;
    public GameObject Enemy;
    public int EnemyNumCurrentRound;
    public int EnemyNumPerRound;
    public SpawnLocation[] spawns;
    private float time;
    private int timeInterval;

    // Use this for initialization
    void Start()
    {
        timeInterval = 5;
        EnemyNumCurrentRound = 0;
        EnemyNumPerRound = 5;
        spawns = FindObjectsOfType<SpawnLocation>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        if (time >= timeInterval)
        {
            time -= timeInterval;
            if (EnemyNumCurrentRound <= EnemyNumPerRound)
            {
                foreach (SpawnLocation spawn in spawns)
                {
                    EnemyScript enemyScript = Enemy.GetComponent<EnemyScript>();
                    enemyScript.enabled = true;
                    enemyScript.Start();
                    enemyScript.enemyData.spawnedLeft = spawn.Left;

                    GameObject newEnemy = (GameObject) Instantiate(Enemy, spawn.transform.position, spawn.transform.rotation);
                    newEnemy.transform.localScale *= 3;
                    EnemyNumCurrentRound++;
                    Debug.Log("EnemyNumPerRound:  " + EnemyNumPerRound);
                    Debug.Log("EnemyNumCurrentRound:  " + EnemyNumCurrentRound);
                }
            }


        }
    }
}
