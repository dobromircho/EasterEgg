using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMove : MonoBehaviour
{

    bool keyUp;
    bool KeyDown;
    Animator animator;
    public float timer;
    bool isLeft;
    bool isRight;
    
    void Start()
    {
        animator = GetComponentInChildren<Animator>();

    }
    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.15f )
        {
            if (isLeft)
            {
                transform.Rotate(new Vector3(0, -90, 0));
                isLeft = false;
            }
            if (isRight)
            {
                transform.Rotate(new Vector3(0, 90, 0));
                isRight = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q) && !isLeft || Input.GetKeyDown(KeyCode.A) && !isLeft )
        {
            transform.Rotate(new Vector3(0, 90, 0));
            if (Input.GetKeyDown(KeyCode.Q))
            {
                
                animator.SetTrigger("up");
                
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.SetTrigger("down");
            }
            timer = 0;
            isLeft = true;
        }
        else if (Input.GetKeyDown(KeyCode.P) && !isRight || Input.GetKeyDown(KeyCode.L) && !isRight)
        {
            transform.Rotate(new Vector3(0, -90, 0));
            if (Input.GetKeyDown(KeyCode.P))
            {
                
                animator.SetTrigger("up");
               
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                animator.SetTrigger("down");
            }
            timer = 0;
            isRight = true;
        }
        else
        {
            
        }
    }

    public void UpRight() // KEY P
    {
        transform.Rotate(new Vector3(0, -90, 0));
        animator.SetTrigger("up");
        timer = 0;
        isRight = true;
    }
    public void DownRight() // KEY L
    {
        transform.Rotate(new Vector3(0, -90, 0));
        animator.SetTrigger("down");
        timer = 0;
        isRight = true;
    }

    public void UpLeft() // KEY Q
    {
        transform.Rotate(new Vector3(0, 90, 0));
        animator.SetTrigger("up");
        timer = 0;
        isLeft = true;
    }
    public void DownLeft() // KEY A
    {
        transform.Rotate(new Vector3(0, 90, 0));
        animator.SetTrigger("down");
        timer = 0;
        isLeft = true;
    }
}
