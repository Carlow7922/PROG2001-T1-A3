﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaPlayer : MonoBehaviour
{
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
        {
            anim.SetBool("run", true);
        }
     else
        {
            anim.SetBool("run", false) ;
        }
    }
}
