using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pipes : MonoBehaviour
{

    public GameObject pipeHigh;
    public GameObject pipeLow;
    public static int score = 0;

    public GameObject text;

    public GameObject Ground1;
    public GameObject Ground2;
    public float pipeSpeed = 1;
    public static LinkedList<GameObject> pipes = new LinkedList<GameObject>();
    private Vector3 resetPos1 = new Vector3(1.561f, -1.058f, 0);
    private Vector3 resetPos2 = new Vector3(1.561f, -1.058f, -1);

    // Start is called before the first frame update
    void Start()
    {
        spawnPipes();
    }

    // Update is called once per frame
    void Update()
    {
        if (FlappyBirdController.playing)
        {
            movePipes();
            moveGround();
            deletePipes();
            spawnPipes();
        }
    }

    void movePipes()
    {
        foreach (GameObject g in pipes)
        {
            g.transform.position -= new Vector3(pipeSpeed, 0, 0) * Time.deltaTime;
            if (Mathf.Abs(g.transform.position.x + 0.2f) < 0.1f)
            {
                score += 1;
                text.GetComponent<UnityEngine.UI.Text>().text = " " + score;
            }
        }
    }

    void moveGround()
    {
        Ground1.transform.position -= new Vector3(pipeSpeed, 0, 0) * Time.deltaTime;
        Ground2.transform.position -= new Vector3(pipeSpeed, 0, 0) * Time.deltaTime;
        if (Ground1.transform.position.x < -1.5)
            Ground1.transform.position = resetPos1;

        if (Ground2.transform.position.x < -1.5)
            Ground2.transform.position = resetPos2;

    }

    void deletePipes()
    {
        for (int x = pipes.Count - 1; x > -1; x--)
        {
            GameObject g = pipes.ElementAt(x);
            if (g.transform.position.x < -1)
            {
                //Should be removed
                Destroy(g);
                pipes.Remove(g);
            }
        }
    }

    public static void deleteEverything()
    {
        for (int x = pipes.Count - 1; x > -1; x--)
        {
            GameObject g = pipes.ElementAt(x);
            //Should be removed
            Destroy(g);
            pipes.Remove(g);
        }
    }

    void spawnPipes()
    {
        if (pipes.Count == 0)
        {
            var height = Random.Range(3f, 4f);
            //Hallo Stream :3

            GameObject pipe = Instantiate(pipeHigh);
            Vector3 v = pipe.transform.position;
            v.y = height;
            pipe.transform.position = v;
            pipes.AddLast(pipe);

            pipe = Instantiate(pipeLow);
            v.y -= 7f + 0.3f; //reverse difficulty TODO
            pipe.transform.position = v;
            pipes.AddLast(pipe);
        }
    }
}
