using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.Mathematics;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Animations;

public class Chase : MonoBehaviour
{
    [SerializeField] private float TurningSpeed; 
    [SerializeField] private Transform target;
    [SerializeField] private float RangeToChase;

    // Update is called once per frame
    void Update()
    {
        var diffVector = target.position - transform.position; 
        Chasing();

        Quaternion NewRotation = Quaternion.LookRotation(diffVector.normalized);
        transform.rotation = Quaternion.Lerp(transform.rotation, NewRotation, Time.deltaTime * TurningSpeed);
    }

    private void Chasing()
    {
        var diffVector = target.position - transform.position;

        if (RangeToChase > diffVector.magnitude)
        {
            transform.LookAt(target);
            Move(diffVector.normalized);


        }
         if (diffVector.magnitude < 3)
        {
          transform.LookAt(target);
        }
    }
    
    private void Move(Vector3 direction)
    {
        var Speed = 2f;   
        transform.position += direction * Speed * Time.deltaTime; 
    }

}
