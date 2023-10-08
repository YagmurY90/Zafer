using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class kontrolling : MonoBehaviour
{
    private Animator animator;
    void Start()
    {

        animator = GetComponent<Animator>();
    }

    private float speed = 4f;

    void Update()
    {
        //Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        //Vector3 hizEklentisi = playerInput * Time.deltaTime * speed;
        //transform.position += hizEklentisi;
    }
    private void FixedUpdate()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        Vector3 hizEklentisi = playerInput * Time.fixedDeltaTime* speed;
        transform.position += hizEklentisi;

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalk", true);
            transform.Translate(new Vector3(0, 2f, 0) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isWalk", false);
            animator.SetBool("normall", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("rightt", true);
            transform.Translate(new Vector3(2f,0 , 0) * Time.deltaTime);

        }
        else
        {
            animator.SetBool("rightt", false);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("leftt", true);
            transform.Translate(new Vector3(-2f, 0, 0) * Time.deltaTime);

        }
        else
        {
            animator.SetBool("leftt", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("backwalkk", true);
            transform.Translate(new Vector3(0, -2f, 0) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("backwalkk", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("jumpp", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("jumpp", false);
        }


    }
}
