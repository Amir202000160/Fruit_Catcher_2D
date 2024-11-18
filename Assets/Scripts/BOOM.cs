using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BOOM : MonoBehaviour
{
    
    // Start is called before the first frame update
    [SerializeField] GameObject boom;
    UI UI;

    void Start()
    {
       boom = GetComponent<GameObject>();
       UI = GameObject.Find("scripts").GetComponent<UI>();


    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BASKET"))
        {
            Destroy(GameObject.FindWithTag("BASKET"));
            UI.GameOver = true;
        }
    }
}
