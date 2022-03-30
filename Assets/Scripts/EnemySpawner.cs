using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class EnemySpawner : MonoBehaviour {
 
     public GameObject Enemy;
     public float spawnTime;
     private int enemyCounter;
     
     private void Start ()
     {
     }
     
     void Update()
     {
         enemyCounter = EnemyCounterHelper.EnemyCounter();

         if (enemyCounter < 5) {
            Instantiate (Enemy, transform.position, Quaternion.identity);
         }

       
     }
 
 }