using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailSpawner : MonoBehaviour
{
    //можно ли создавать
    public bool isSpawnready;
    //время между спанвами
    public float timeBetweenSpawn;
    
    //массив деталей
    public GameObject[] Details;
   
    


    private void Awake()
    {
        Time.timeScale = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject controller = GameObject.Find("Controller");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isSpawnready)
        {
            StartCoroutine(SpawnDetail());
        }
        
    }
    IEnumerator SpawnDetail()
    {
        GameObject detail = Details[Random.Range(0, Details.Length)];
        isSpawnready = true;
        Instantiate(detail, detail.transform.position, detail.transform.rotation);
        yield return new WaitForSeconds(timeBetweenSpawn);
        isSpawnready = false;
    }
}
