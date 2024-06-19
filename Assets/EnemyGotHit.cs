using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGotHit : MonoBehaviour
{
    public float score = 0;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("why");
        if (other.tag == "Food")
        {
            ///GameManager.instance.score += this.score;
            Destroy(gameObject);
            Destroy(other.gameObject);
            
        }
    }
}
