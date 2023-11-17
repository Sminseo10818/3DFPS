using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            animator.SetBool("Aim", true);
        }
        else
        {
            animator.SetBool("Aim", false);
        }

        if (Input.GetMouseButton(0))
        {
            animator.SetBool("Fire", true);
        }
        else
        {
            animator.SetBool("Fire", false);
        }
    }
}
