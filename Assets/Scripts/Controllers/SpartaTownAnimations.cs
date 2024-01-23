using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpartaTownAnimations : MonoBehaviour
{
    protected Animator animator;
    protected SpartaTownCharacterController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<SpartaTownCharacterController>();
    }
}
