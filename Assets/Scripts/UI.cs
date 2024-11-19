using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int SCORE;
    public bool GameOver;
    public bool IsStart;
    public Transform title;
    public Text scoreboard;
    public GameObject StartPanel;


    void Start()
    {
        SCORE = 0;
        GameOver = false;
        IsStart = false;
        scoreboard.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver == true)
        {
            title.localPosition = new Vector3(0, 0, 0);
            GameOver =false;
        }
        
    }
    public void ScoreADD()
    {
        SCORE=SCORE+1;
        scoreboard.text = SCORE.ToString();
    }
    public void NEWGAME()
    {
        SceneManager.LoadScene(0);
    }
    public void EXIT()
    {
        Application.Quit();
    }
    public void StartNewGame()
    {
        StartPanel.gameObject.SetActive(false);
        IsStart = true;
    }
}
