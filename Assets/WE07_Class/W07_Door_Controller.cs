using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W07_Door_Controller : MonoBehaviour
{
    public GameObject Target;
    public Animator animator;
    // Start is called before the first frame update
    private void Start()
    {
        //animator=GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name+"entered");
        animator.SetInteger("DoorState",1);
    }
    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name+"exited");
        animator.SetInteger("DoorState",2);
    }
}
