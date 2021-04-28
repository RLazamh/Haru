using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    float speed=4f;
    Animator animator;
    Rigidbody2D rb2d;
    Vector2 mov;
    
    void Start()
    {
        animator=GetComponent<Animator>();
        rb2d=GetComponent<Rigidbody2D>();
    
    }    
    void Update()
    {
        
        mov = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
        /*
        transform.position=Vector3.MoveTowards(
            transform.position,
            transform.position + mov,
            speed*Time.deltaTime
        );
        */
        if(mov != Vector2.zero){
            animator.SetFloat("movX",mov.x);
            animator.SetFloat("movY",mov.y);
            animator.SetBool("walking",true);
        }
        else{
            animator.SetBool("walking",false);
        }
        

       // transform.position= new Vector3 (posicion,-4.01f,-1f);
    }
    void FixedUpdate(){
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
    }
    /*
    void OnTriggerEnter2D(){
        Destroy(gameObject);
    }
    */
}
