using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pipes : MonoBehaviour
{

    public GameObject pipeHigh;
    public GameObject pipeLow;
    public float pipeSpeed = 1;
    private LinkedList<GameObject> pipes = new LinkedList<GameObject>();
    
    // Start is called before the first frame update
    void Start() {
        spawnPipes();
    }

    // Update is called once per frame
    void Update(){
        movePipes();
        deletePipes();
        spawnPipes();
    }

    void movePipes() {
        foreach (GameObject g in pipes)
        {
            g.transform.position -= new Vector3(pipeSpeed, 0, 0) * Time.deltaTime;
        }
    }

    void deletePipes()
    {
        for(int x = pipes.Count-1; x > -1; x--) {
            GameObject g = pipes.ElementAt(x);
            if (g.transform.position.x < -1) {
                //Should be removed
                Destroy(g);
                pipes.Remove(g);
            }
        }
    }

    void spawnPipes() {
        if(pipes.Count == 0)
        {
            var height = Random.Range(0.8f,1.8f);
            //Hallo Stream :3

            GameObject pipe = Instantiate(pipeHigh);
            Vector3 v = pipe.transform.position;
            v.y = height;
            pipe.transform.position = v;
            pipes.AddLast(pipe);

            pipe = Instantiate(pipeLow);
            v.y -= 2f + 0.3f; //reverse difficulty TODO
            pipe.transform.position = v;
            pipes.AddLast(pipe);
        }
    }
}
