using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int score;
    const int DEFAULT_POINTS = 1;
    [SerializeField] Text scoreText;
    [SerializeField] Text sceneText;
    [SerializeField] Text nameText;
    [SerializeField] int level;
    const int SCORE_THRESHOLD_PER_LEVEL = 4;

    [SerializeField] int scoreThresholdForThisLevel;

    // Start is called before the first frame update
    void Start()
    {
        reset();
        score = PersistentData.Instance.GetScore();
        level = SceneManager.GetActiveScene().buildIndex;
        scoreThresholdForThisLevel = SCORE_THRESHOLD_PER_LEVEL * level;
        
        DisplayScore();
        DisplayName();
        //DisplayLevel();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void UpdateScore(int addend)
    {
        score += addend;
        Debug.Log("score" + score);

        DisplayScore();
        PersistentData.Instance.SetScore(score);

        if (score >= scoreThresholdForThisLevel)
        {
            //move on to next level
            SceneManager.LoadScene(level + 1);
        }
    }

    public void UpdateScore()
    {
        UpdateScore(DEFAULT_POINTS);
    }

    /*
    public void AddPoints(int points)
    {
        score += points;
        Debug.Log("score " + score);
        DisplayScore();

        if (score > SCORE_THRESHOLD)
            AdvanceLevel();

    }*/

    /*
    public void AddPoints()
    {
        AddPoints(DEFAULT_POINTS);
    }*/

    public void DisplayScore()
    {
        scoreText.text = "Score: " + score;
    }

 /*   public void DisplayLevel()
    {
        int levelToDisplay = level;
        sceneText.text = "Level " + levelToDisplay;
        //sceneText.text = "Level: " + (level+1);
    } */

    public void DisplayName()
    {
        nameText.text = PersistentData.Instance.GetName();
    }

    public void AdvanceLevel()
    {
        SceneManager.LoadScene(level + 1);
    }

    public void reset(){
        score = 0;
        PlayerPrefs.SetInt("score", score);
    }

}