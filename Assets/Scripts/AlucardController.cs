using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlucardController : MonoBehaviour
{
    public GameObject shot;
    public Sprite jump;
    private SpriteRenderer spriteRenderer; 
    // Start is called before the first frame update
    void Start()
    {
         spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
       GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * 0, Input.GetAxis("Vertical")*10);

        if (Input.GetButtonDown("Fire1")){
            Instantiate(shot, transform.position, Quaternion.identity);
        } 


        if (Input.GetKeyDown("up")) // If the space bar is pushed down
        {
            ChangeTheDamnSprite("jump"); // call method to change sprite
        }
    }

    void ChangeTheDamnSprite(string option)
    {
        switch (option) {
            case "jump": 
                spriteRenderer.sprite = jump;
                break;
            case "right":
                break;

            case "left":
                break;
        } 
    }   

    
}
