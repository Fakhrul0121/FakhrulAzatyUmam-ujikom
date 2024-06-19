using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodHandler : MonoBehaviour
{
    public float foodTimeout = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyWhenTimeout());
    }

    IEnumerator DestroyWhenTimeout()
    {
        yield return new WaitForSeconds(foodTimeout);
        Destroy(gameObject);
    }
}
