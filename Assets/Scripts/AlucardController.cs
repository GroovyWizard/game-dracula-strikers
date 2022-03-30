using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlucardController : MonoBehaviour
{
    public GameObject shot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * 0, Input.GetAxis("Vertical")*10);

        if (Input.GetButtonDown("Fire1")){
            Instantiate(shot, transform.position, Quaternion.identity);
        } 
    }
}
