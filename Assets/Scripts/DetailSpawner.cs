using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailSpawner : MonoBehaviour
{
    //можно ли создавать
    public bool isSpawnready;
    //время между спанвами
    public float timeBetweenSpawn;
    private CubeController forscore;
    //массив деталей
    public GameObject[] Details;
    private bool level2complete;
    private bool level3complete;
    private bool level4complete;

    private void Awake()
    {
        Time.timeScale = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject controller = GameObject.Find("Controller");
        forscore = controller.GetComponent<CubeController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isSpawnready)
        {
            StartCoroutine(SpawnDetail());
        }
        if ( forscore.Score >= 500 && !level2complete)
        {
            timeBetweenSpawn -= 1;
            level2complete = true;
        }
        if ( forscore.Score >= 1000 && !level3complete)
        {
            timeBetweenSpawn -= 1;
            level3complete = true;
        }
        if ( forscore.Score >= 2000 && !level4complete)
        {
            timeBetweenSpawn -= 1;
            level4complete = true;
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
