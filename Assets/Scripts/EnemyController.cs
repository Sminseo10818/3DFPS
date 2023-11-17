using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{
    NavMeshAgent nav;
    GameObject target;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nav.destination != target.transform.position)
        {
            nav.SetDestination(target.transform.position);
            animator.SetBool("Chasing", true);
        }
        else
        {
            nav.SetDestination(transform.position);
            animator.SetBool("Chasing", false);
        }
    }
}
