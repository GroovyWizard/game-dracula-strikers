using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlucardMovement : MonoBehaviour
{
     public float speed;
 
     void Update ()
     {
         transform.Translate (Input.GetAxisRaw ("Horizontal") * speed, Input.GetAxisRaw ("Vertical") * speed, 0);
     }
}
