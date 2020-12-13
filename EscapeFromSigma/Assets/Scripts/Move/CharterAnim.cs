using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharterAnim : MonoBehaviour
{
    private Animator anim;

    void Start()

    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isRunningDown", true);
        }
        else
        {
            anim.SetBool("isRunningDown", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isRunningUp", true);
        }
        else
        {
            anim.SetBool("isRunningUp", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isRunningLeft", true);
        }
        else
        {
            anim.SetBool("isRunningLeft", false);
        }


        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isRunningRight", true);
        }
        else
        {
            anim.SetBool("isRunningRight", false);
        }

        /*if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isRunningUp", true);
            anim.SetBool("isRunningLeft", true);
        }
        else
        {
            anim.SetBool("isRunningUp", false);
            anim.SetBool("isRunningLeft", false);
        }*/

        if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.S)))
        {
            anim.SetBool("isRunningDown", false);
            anim.SetBool("isRunningUp", false);
        }


        if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.D)))
        {
            anim.SetBool("isRunningRight", false);
            anim.SetBool("isRunningLeft", false);
        }

    }

}
