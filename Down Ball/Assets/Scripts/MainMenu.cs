using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    //public Text Score;
    public Text HighScore;
    float highscore = 0;
    
    public GameObject optionPanel;
    public GameObject anaMenuPanel;
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        highscore = PlayerPrefs.GetFloat("kayit");
        //float score = PlayerPrefs.GetFloat("score");

        HighScore.text = "" + highscore*10;
        //Score.text = "" + score;
        Debug.Log(highscore);
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("level1");     
    }

    public void OptionMenu()
    {
        optionPanel.SetActive(true);
        anaMenuPanel.SetActive(false);
    }

    public void backButton()
    {
        optionPanel.SetActive(false);
        anaMenuPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
	
}
