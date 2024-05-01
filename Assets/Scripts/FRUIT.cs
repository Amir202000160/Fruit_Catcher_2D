using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FRUIT : MonoBehaviour
{
   [ SerializeField ]   Rigidbody2D rb;
    UI UI;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        UI =GameObject.Find("scripts").GetComponent<UI>();
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "BASKET") 
        {
            Destroy(this.gameObject);
            UI.ScoreADD();
        }
        if (collision.gameObject.tag == "GROUNID")
        {
            Destroy(this.gameObject);
        }
        
    }

}
