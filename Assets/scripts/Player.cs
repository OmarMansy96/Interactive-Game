using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject player;
    public float hAxis,vAxis,moveSpeed, runSpeed,jump;
    private Vector3 movement;
    Rigidbody rb;
    public Animator anim;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();

     
        
        
    }


    void Update()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");
       
        Move();

        

    }
    void Move()
    {
        movement.z = vAxis;
        if( Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(new Vector3(movement.x, movement.y, movement.z) * runSpeed * Time.deltaTime);
            anim.SetFloat("fastRun", vAxis);
            anim.SetTrigger("sheft");
        }
       
            transform.Translate(new Vector3(movement.x, movement.y, movement.z) * moveSpeed * Time.deltaTime);
            anim.SetFloat("run",vAxis);

            transform.Rotate(0,hAxis,0);
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jump, 0));
            anim.SetTrigger("jump");
        }
    }
}
