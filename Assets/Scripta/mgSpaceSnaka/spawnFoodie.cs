using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFoodie : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject foodiePrefub;

    public Transform borderHorizontalTop;
    public Transform borderHorizontalBottom;
    public Transform borderVerticalRight;
    public Transform borderVerticalLeft;
    void Start()
    {
        InvokeRepeating("Spawn", 3, 4); 
    }

    // Update is called once per frame
    void Spawn()
    {
        int dx = (int) Random.Range(borderVerticalLeft.position.x, borderVerticalRight.position.x);
        int dy = (int) Random.Range(borderHorizontalBottom.position.y, borderHorizontalTop.position.y);
        Instantiate(foodiePrefub, new Vector2(dx, dy), Quaternion.identity); //default rotation
    }
    void Update()
    {
        
    }
}
