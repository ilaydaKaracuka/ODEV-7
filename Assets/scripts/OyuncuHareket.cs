using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
 
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        
    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) //ileri
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime); //z de hareket etsin konum deðiþtirsin
        }
        else
            animator.SetBool("isWalking", false); //tikli deðilse dursun


        if (Input.GetKey(KeyCode.A)) //sola
        {
            animator.SetBool("isWalkingLeft", true);
            transform.Translate(new Vector3(-2f, 0,0 ) * Time.deltaTime); 
        }
        else
            animator.SetBool("isWalkingLeft", false); 

        
        if (Input.GetKey(KeyCode.D)) //saða
        {
            
            animator.SetBool("isWalkingRight", true);
            transform.Translate(new Vector3(2f, 0, 0) * Time.deltaTime); 
        }
        else
            animator.SetBool("isWalkingRight", false); 


        if (Input.GetKey(KeyCode.R))  // R ile kos
        {
            animator.SetBool("isRunning", true);
            transform.Translate(new Vector3(0, 0, 5f) * Time.deltaTime); //z de hareket etsin konum deðiþtirsin
        }
        else
            animator.SetBool("isRunning", false);
       
        if (Input.GetKey(KeyCode.Space)) //Space ile zýpla
        {
            animator.SetBool("isJump", true);
            
            
            transform.Translate (new Vector3(0, 8f, 0) * Time.deltaTime);
            

        }
        else
            animator.SetBool("isJump", false);
    }
}
