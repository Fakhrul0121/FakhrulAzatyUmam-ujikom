using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    CharacterController enemyController;

    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        enemyController = GetComponent<CharacterController>();
        StartCoroutine(destoryEnemyTimeout());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemyController.Move(new Vector3(0,0,-speed));
    }

    IEnumerator destoryEnemyTimeout()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
