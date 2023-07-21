using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    public CharacterController player;
    public float hAxis,vAxis,moveSpeed, runSpeed, jump=5f;
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
        //movement = new Vector3(hAxis, movement.y, vAxis);

        movement.z = vAxis;

       
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(movement.x,0f,movement.z * runSpeed * Time.deltaTime);
                
            }
                transform.Translate(movement.x, 0f, movement.z * moveSpeed * Time.deltaTime);
                anim.SetFloat("run", vAxis);
                transform.Rotate(0, hAxis, 0);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, jump, 0));

                movement.y = jump * Time.deltaTime;

                anim.SetTrigger("jump");
            }
        


    }
  




}
