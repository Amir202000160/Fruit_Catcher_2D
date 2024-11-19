using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GENERATOR : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 1;
    [SerializeField] GameObject[] gm;
    UI UI;
    void Start()
    {
        UI = GameObject.Find("scripts").GetComponent<UI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UI.IsStart == true)
        {
            Generator();
        }

    }
    private void Generator()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            int chance = Random.Range(1, 201);
            float pos_X = Random.Range(-7.0f, 7.0f);
            if (chance <= 30)
            {
                Instantiate(gm[0], new Vector3(pos_X, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            else if (chance <= 60)
            {
                Instantiate(gm[1], new Vector3(pos_X, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            else if (chance <= 90)
            {
                Instantiate(gm[2], new Vector3(pos_X, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            else if ((chance <= 100))
            {
                Instantiate(gm[3], new Vector3(pos_X, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            timer = 0.5f;
        }

    }
}
