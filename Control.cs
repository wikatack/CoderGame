using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float rotationSpeed = 100f;

    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }

   
        float input = Input.GetAxisRaw("Horizontal");

        transform.rotation *= Quaternion.Euler(0f, input * rotationSpeed * Time.deltaTime, 0f);


    }
}
 