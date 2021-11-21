using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemy;
    [SerializeField]
    public Text text;
    private float spawnTime;
    private float spawndelay = 5;
    private int timer;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnPoints.Length > 0 && spawnTime > spawndelay)
        {
            if (spawndelay > 1) spawndelay -= 0.2f;

            spawnTime = 0;

            
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation).GetComponent<EnemyMovement>().myText = text;
            for(int i = getSpawnpoints(); i >= 0; i--)
            {
                spawnPointIndex = Random.Range(0, spawnPoints.Length);
                Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation).GetComponent<EnemyMovement>().myText = text; ;
            }
        }



    }

    private int getSpawnpoints()
    {
        int random = Random.Range(0, 10);
        return (int)(Mathf.Pow(random,3)/50)+3;
    }
}
