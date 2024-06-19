using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchFood : MonoBehaviour
{

    public GameObject foodProjectile;

    private IEnumerator shootingFoodCorontinue;

    public float shootDelay = 1f;

    public float shootVelocity = 100f;

    Animator animator;

    bool isShooting;

    public GameObject playerModel;

    private void Start()
    {
        animator = playerModel.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        ////isShooting = Input.GetButtonDown("Fire");
       /// animator.SetBool("IsShooting", isShooting);
        if (Input.GetButtonDown("Fire")) {
            shootingFoodCorontinue = ShootFoodContinuesly();
            StartCoroutine(shootingFoodCorontinue);
        };

        if (Input.GetButtonUp("Fire")) StopCoroutine(shootingFoodCorontinue);
        /////Debug.Log(isShooting);

    }

    IEnumerator ShootFoodContinuesly()
    {
        while (true){
            ShootFood();
            yield return new WaitForSeconds(shootDelay);
        }
    }

    void ShootFood()
    {
        GameObject food = Instantiate(foodProjectile, transform.parent);
        food.transform.position = transform.position;
        food.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0f,0f,shootVelocity));
    }
}
