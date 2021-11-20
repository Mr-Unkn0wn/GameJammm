using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallWatcher : MonoBehaviour
{
    private float nextSpawnTime;
    private Int32 killedHearts;
    public GameObject circlePrefab;
    private List<GameObject> enemyList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        killedHearts = 0;
        nextSpawnTime = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        for(int index = 0; index < enemyList.Count; index++)
        {
            GameObject heart = enemyList[index].transform.GetChild(0).gameObject;
            if (heart.GetComponent<BallsMovingScript>().wasDefended)
            {
                Destroy(enemyList[index]);
                enemyList.RemoveAt(index);
                killedHearts++;
            }
            if (heart.GetComponent<BallsMovingScript>().hasHitted)
            {
                GameObject.Find("ShowHearts").GetComponent<HealthBar>().TakeLife();
                Destroy(enemyList[index]);
                enemyList.RemoveAt(index);
            }
        }
        if(Time.time > nextSpawnTime)
        {
            Int32 number = (killedHearts / 20) + 1;
            if(number > 10)
            {
                nextSpawnTime += 0.5f;
                SpawnCircles((int)(number/10));
            }
            else
            {
                nextSpawnTime += 2.5f;
                SpawnCircles(number);
            }
        }
    }

    private void SpawnCircles(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            enemyList.Add(createCircleObject());
        }
    }

    private GameObject createCircleObject()
    {
        float xPosition = UnityEngine.Random.value * 15 - 7.5f;
        float yPosition = UnityEngine.Random.value * 4;
        GameObject nextObject = Instantiate(circlePrefab, new Vector3(xPosition, yPosition, 0), Quaternion.identity);
        return nextObject;
    }
}
