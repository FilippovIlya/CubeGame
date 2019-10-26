using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMove : MonoBehaviour
{
    public GameObject DetailSpawner;
    public float speed;
    public bool doehali;
    // Start is called before the first frame update
    void Start()
    {
        DetailSpawner = GameObject.Find("DetailSpawner");
        //Destroy(gameObject, 30);
    }

    // Update is called once per frame
    void Update()
    {
        if (!doehali)
        {
            transform.position = Vector3.MoveTowards(transform.position, DetailSpawner.transform.position, speed * Time.deltaTime);
            if(transform.position == DetailSpawner.transform.position)
            {
                doehali = true;
            }
        }
    }
}
