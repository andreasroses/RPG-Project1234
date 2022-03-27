using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    // movement speed
    public float moveSpeed;

    // check if player is moving
    private bool isMoving;

    // user input
    private Vector2 input;

    /*private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }*/

    

    // Update is called once per frame

    private void Update()
    {
        if(!isMoving)
        {
            // x-axis
            input.x = Input.GetAxisRaw("Horizontal");
            // y-axis
            input.y = Input.GetAxisRaw("Vertical");

            // remove diagonal movement
            if (input.x != 0) input.y = 0;

            if (input != Vector2.zero)
            {
                /*animator.SetFloat("moveX", input.x);
                animator.SetFloat("moveY", input.y);*/
                // target position is equal to current position of player plus input
                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;

                StartCoroutine(Move(targetPos));
            }
        }
    }

    // moving from current position to target position 
    // IEnumerator return type
    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;

        isMoving = false;
    }

}

