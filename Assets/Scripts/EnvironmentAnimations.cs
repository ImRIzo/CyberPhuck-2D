﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentAnimations : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Waterfall", true);
    }
}