using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGotHit : MonoBehaviour
{
    public float score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            GameManager.instance.score += this.score;
            Destroy(gameObject);
            Destroy(other.gameObject);
            
        }
    }
}
