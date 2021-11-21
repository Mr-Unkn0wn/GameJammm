using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public Text text;

    private int health;
    private float timer;
    private GameObject[] finalHearts;
    [SerializeField]
    private Score score;


    // Start is called before the first frame update
    void Start()
    {
        finalHearts = new GameObject[hearts.Length];
        foreach(GameObject gObject in hearts)
        {
            finalHearts[health++] = Instantiate(gObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (health == 0)
        {

            GameObject obj = GameObject.FindGameObjectWithTag("Score");
            Score tmp;
            if (obj == null) tmp = Instantiate(score).GetComponent<Score>();
            else tmp = obj.GetComponent<Score>();
            tmp.score = int.Parse(text.text);
            SceneManager.LoadScene("DeathScene");
           
        }
    }

    public void damagePlayer()
    {

        if (health > 0 && timer > 0.5f)
        {
            Destroy(finalHearts[--health]);
            timer = 0;
        }
    }
}
