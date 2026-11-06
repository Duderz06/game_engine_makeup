using System.Collections;
using UnityEngine;

public class maketheenemoies : MonoBehaviour
{
    private EnemySpawner ES;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ES = FindAnyObjectByType<EnemySpawner>();
        StartCoroutine(Go());
        Debug.Log("a");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator Go()
    {

        while (true) { 
        
        yield return new WaitForSeconds(3);

            SpawnEnemy();

        }

    }


    public void SpawnEnemy()
    {

        Debug.Log("b");

        ES.EnemyNum = 1;
        ES.SpawnPoint = transform;
        ES.Spawn(transform);

    }

}
