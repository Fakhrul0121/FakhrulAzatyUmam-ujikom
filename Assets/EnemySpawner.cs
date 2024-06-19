using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyList;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy());
    }

    IEnumerator spawnEnemy()
    {
        while (true)
        {
            GameObject enemy = Instantiate(enemyList[Random.Range(0, enemyList.Length)], new Vector3(Random.Range(-4f, 4f), 0f, 20f),transform.rotation, transform.parent);
            Debug.Log(enemy);
            Debug.Log("enemy position" + enemy.transform.position);
            yield return new WaitForSeconds(5);
        }
    }
}
