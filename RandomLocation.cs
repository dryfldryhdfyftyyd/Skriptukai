using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation : MonoBehaviour
{
    public float moveRange = 50f;
    public float moveSpeed = 10f; 

    private Vector3 targetPosition;

    void Start()
    {
        
        SetRandomTargetPosition();
    }

    void Update()
    {
       
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            
            SetRandomTargetPosition();
        }
    }

    void SetRandomTargetPosition()
    {
        
        float randomX = Random.Range(-moveRange, moveRange);
        float randomZ = Random.Range(-moveRange, moveRange);

        
        targetPosition = new Vector3(randomX, 0f, randomZ);
    }
}
