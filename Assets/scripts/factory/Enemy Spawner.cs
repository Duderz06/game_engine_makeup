using UnityEngine;

public class EnemySpawner : MonoBehaviour
{



    public EnemyFactory EF;
    public Transform SpawnPoint;

    public int EnemyNum = 0;

    public void Spawn(Transform Parent)
    {
        Debug.Log("C");

        if (EF == null || SpawnPoint == null)
        {
            Debug.Log("rutents");

            return;
        }
        Debug.Log("yyy");

        EF.SpawnEnemy(EnemyNum, SpawnPoint.position, Parent);


    }



}
