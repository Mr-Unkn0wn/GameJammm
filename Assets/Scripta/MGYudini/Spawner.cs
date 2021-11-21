using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemy;
    [SerializeField]
    public GameObject player;
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

            int[] reachedInts = new int[spawnPoints.Length+1];
            for(int i = Mathf.Min(getSpawnpoints(),reachedInts.Length-1); i >= 0; i--)
            {
                int spawnPointIndex = Random.Range(0, spawnPoints.Length-1);
                while (reachedInts[spawnPointIndex++ % (reachedInts.Length)] != 0) { }
                int spawnpoint = --spawnPointIndex % (reachedInts.Length);
                reachedInts[spawnpoint]++;
                GameObject tmp = Instantiate(enemy, spawnPoints[spawnpoint % spawnPoints.Length].position, spawnPoints[spawnpoint % spawnPoints.Length].rotation);
                tmp.GetComponent<EnemyMovement>().myText = text;
                tmp.GetComponent<EnemyMovement>().playerHealth = player.GetComponent<HealthSystem>();
            }
        }



    }

    private int getSpawnpoints()
    {
        int random = Random.Range(0, 10);
        return (int)(Mathf.Pow(random,3)/40)+3;
    }
}
