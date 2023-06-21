using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject player;
    public float axisH,axisV,moveSpeed, runSpeed,jump;
    private Vector3 vector;
    Rigidbody rb;
    

    void Start()
    {
        axisH = Input.GetAxis("Horizontal");
        axisV = Input.GetAxis("Vertical");
        
        
    }


    void Update()
    {
        if(axisH > 0)
        {

        }
        
    }
}
