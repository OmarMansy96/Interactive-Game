using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblin : MonoBehaviour
{
    private Animator goblinAnim;
    void Start()
    {
        goblinAnim = GetComponent<Animator>();
    }

    void Update()
    {

    }

    public void Sit()
    {
        goblinAnim.SetBool("sit", true);
    }
    public void StandUp()
    {
        goblinAnim.SetBool("sit", false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Is triggered: " + other.name);
        if (other.gameObject.tag == "Player")
        {
            StandUp();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Sit();
        }
    }
   
}
