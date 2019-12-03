using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 5f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal= Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(horizontal > 0)
        {
            transform.Translate(new Vector3(velocidad, 0, 0) * Time.deltaTime);

        }else if(horizontal < 0)
        {
            transform.Translate(new Vector3(-velocidad, 0, 0) * Time.deltaTime);
        }

        if (Input.GetAxis("Jump") == 1)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }

}
