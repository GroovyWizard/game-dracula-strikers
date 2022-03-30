using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Transform target;
    public float speed = 2f;
    private float minDistance = 1f;
    private float range;
     void FixedUpdate ()
         {
             target = GameObject.FindGameObjectWithTag("Player").transform; 
             range = Vector2.Distance(transform.position, target.position);
             if (range > minDistance)
             {
     
                 transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
             }
         }

}

