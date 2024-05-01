using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class moving_bascket : MonoBehaviour

{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 5f;
    private float move;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        
        if (move < 0)
        {
            rb.velocity = new Vector2(move * speed, rb.velocity.y) ;
        }
        else
        {
            rb.velocity = new Vector2(move * speed, rb.velocity.y);


        }









    }
}
