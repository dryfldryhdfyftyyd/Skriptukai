using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activation : MonoBehaviour
{
   
    public Transform player; 
    public float activationDistance = 10f;
    public float deactivationDistance = 40f; 

    private Enemy enemy;
    private RandomLocation randomLocation;
        

    void Start()
    {
        
        enemy = GetComponent<Enemy>();
    }

    void Update()
    {
        
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        
        if (distanceToPlayer <= activationDistance)
        {
            ActivateEnemy();
        }
        
        else if (distanceToPlayer >= deactivationDistance)
        {
            DeactivateEnemy();
        }
    }

    void ActivateEnemy()
    {
        
        if (enemy != null)
        {
            
            enemy.enabled = true;

            
        }

        
    }

    void DeactivateEnemy()
    {
        if (enemy != null)
        {

            enemy.enabled = false;


        }
        if (randomLocation != null)
        {
            
            randomLocation.enabled = true;

            
        }

       
    }
}
