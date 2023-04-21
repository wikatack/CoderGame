using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private Vector3 m_position;
    [SerializeField] private float initalTime;
    
    private float currentTime;
    private Vector3 Scale;






    private void Awake()
    {

       

        currentTime = initalTime;
    }
    private void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime < 0)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += new Vector3 (2,2,2);
        }

        Scale = transform.localScale;
        
        m_position = transform.position;
        
        transform.position += m_speed * Time.deltaTime * transform.right;
    }
}