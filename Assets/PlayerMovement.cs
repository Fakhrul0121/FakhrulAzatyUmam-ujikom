using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    CharacterController playerController;

    Vector3 direction;
    public float speed;

    public float positionClamp = 8f;

    Animator animator;

    bool isMoving;

    public GameObject playerModel;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<CharacterController>();
        animator = playerModel.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Xaxis", direction.x);
        Debug.Log(direction);
    }

    private void FixedUpdate()
    {
        isMoving = direction.magnitude >= 0.1f;
        Debug.Log(isMoving);
        if (isMoving) movePlayer();
        animator.SetBool("IsMoving", isMoving);
    }

    void movePlayer()
    {
        playerController.Move(direction * speed);
        ClampPosition();
    }

    void ClampPosition()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -positionClamp, positionClamp),0,0);
    }
}
