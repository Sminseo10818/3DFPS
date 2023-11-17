using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FireController : MonoBehaviour
{
    public Transform Aimtr;

    // Start is called before the first frame update
    void Start()
    {
        Aimtr = GameObject.Find("AimSpot").GetComponent<Transform>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Aimtr.position, Aimtr.transform.forward, out hit))
            {
                if (hit.collider.tag == "enemy")
                {
                    hit.collider.gameObject.GetComponent<Animator>().SetBool("Damaged", true);
                    hit.collider.gameObject.GetComponent<NavMeshAgent>().speed = 0f;
                    Destroy(hit.collider.gameObject, 3.0f);
                }
            }
        }
    }
}
