using UnityEngine;
using System.Collections;

public class EnemyFire : MonoBehaviour
{
    public float maxFireInterval = 3.0f;

    //public string debugFiring = "null";

    public float multiplyingVar= 2.5f;

    public GameObject bullet;

    public GameObject[] Enemies;

    //float usedNumberOfEnemies = 1;

    int currentNumberOfEnemies;

    public float minFireLerpDelay = 2;

    public float maxFireLerpDelay = 4;

    int totalNumberOfEnemies;

    bool firstFireTime = true;

    // Use this for initialization
    void Start()
    {
        currentNumberOfEnemies = totalNumberOfEnemies = CountEnemies();
        

        StartCoroutine(FireAfter());
    }
    
    public IEnumerator FireAfter()
    {
        float percentageOfEnemiesRemaining = (float) currentNumberOfEnemies / totalNumberOfEnemies;
        float minFireInterval = Mathf.Lerp(minFireLerpDelay, maxFireLerpDelay, percentageOfEnemiesRemaining);
        float delay = 0;
        if (firstFireTime)
        {
            maxFireInterval = maxFireInterval - minFireInterval;
            minFireInterval = 0.1f;
            
        }
        delay = Random.Range(minFireInterval, maxFireInterval);
        yield return new WaitForSeconds(delay);
        SpawnBullet();
        StartCoroutine(FireAfter());
        firstFireTime = false;

    }

    public void SpawnBullet()
    {
        //Debug.Log(debugFiring);
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = transform.position;
    }

    // Update is called once per frame

    public int CountEnemies()
    {
        GameObject[] amountOfEnemies = GameObject.FindGameObjectsWithTag("Enemies");

        return amountOfEnemies.Length;
    }

    void Update()
    {
        currentNumberOfEnemies = CountEnemies();

        /*usedNumberOfEnemies = currentNumberOfEnemies * multiplyingVar;*/

        if (Input.GetKeyDown(KeyCode.I))
        {
            GameObject spawnedBullet = Instantiate(bullet);
            spawnedBullet.transform.position = transform.position;
        }
        //Debug.Log(numberOfEnemies);

        /*float fireInterval = Random.Range(0.0f, 1.0f);

        //Fire on random interval

        //Create entity "Bullet" and direct
        if (fireInterval > fireIntervalVar || Input.GetKeyDown(KeyCode.I))
        {
            GameObject spawnedBullet = Instantiate(bullet);

            spawnedBullet.transform.position = transform.position;
        }*/

    }
}
