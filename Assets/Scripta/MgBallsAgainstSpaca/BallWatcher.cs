using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallWatcher : MonoBehaviour
{
    private List<GameObject> enemyList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        enemyList.Add(createCircleObject());
    }

    // Update is called once per frame
    void Update()
    {
        for(int index = 0; index < enemyList.Count; index++)
        {
            if (enemyList[index].GetComponent<BallsMovingScript>().wasDefended)
            {
                Destroy(enemyList[index]);
                enemyList.RemoveAt(index);
                SpawnCircles(2);
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
        GameObject nextObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        float xPosition = Random.value * 15 - 7.5f;
        float yPosition = Random.value * 2 + 2;
        nextObject.transform.position = new Vector3(xPosition, yPosition, 0);
        nextObject.AddComponent<CircleCollider2D>();
        nextObject.AddComponent<Rigidbody2D>();
        nextObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        nextObject.AddComponent<BallsMovingScript>();
        return nextObject;
    }
}
