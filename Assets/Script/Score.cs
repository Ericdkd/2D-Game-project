using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    [SerializeField] int score = 0;
    [SerializeField] int staticScore = 0;
    [SerializeField] int totalAmountOfBalloons = 3;
    [SerializeField] Text scoreText;
    [SerializeField] Text sceneText;
    [SerializeField] Text playerText;
    [SerializeField] int level;

    // public GameObject Player;
    public int Respawn;
    public int calculatedBalloons;
    
    // Start is called before the first frame update
    void Start()
    {
        reset();
        score = PlayerPrefs.GetInt("score");
        staticScore = PlayerPrefs.GetInt("score");
        DisplayScene();
        DisplayScore();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        int level = SceneManager.GetActiveScene().buildIndex;
        if(score < 0){
            score = 0;
        }

        if(level == 3){
            reset();
        }
    }

    public void DisplayScore()
    {
        scoreText.text = "score: " + score;
        
    }

    public void DisplayScene()
    {
        //sceneText.text = "Level: " + (level + 1);
        int firstLevelDisplayNum = 1;
        int secondLevelDisplayNum = 2;
        int thirdLevelDisplayNum = 3;

        int sceneNum = SceneManager.GetActiveScene().buildIndex;
        //int level = SceneManager.GetActiveScene().buildIndex;
        //int levelScene = SceneManager.GetSceneAt(sceneNum);
        if (sceneNum == 1)
        {
        //sceneText.text = "Level " + level;
        sceneText.text = "Level " + firstLevelDisplayNum;
        }
        if (sceneNum == 2)
        {
        sceneText.text = "Level " + secondLevelDisplayNum;
        }
        if (sceneNum == 3)
        {
        sceneText.text = "Level " + thirdLevelDisplayNum;
        }
    }

    public void AdvanceLevel()
    {
        SceneManager.LoadScene(level + 1);
    }


    public void IncrementScore(int amountPopped)
    {
        int previousScore = staticScore;
        calculatedBalloons = previousScore + totalAmountOfBalloons;
        
        if (amountPopped > 0)
        {
        score += amountPopped;
        PlayerPrefs.SetInt("score", score);
        DisplayScore();
        }
        else 
        {
            Debug.Log("Invalid. Amount of popped ballons is less than 0");
        }

        //if (score == calculatedBalloons)
        if(score == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    public void IncrementScore()
    {
        IncrementScore(1);
    }

    public void nextScene(){
        SceneManager.LoadScene(Respawn);
    }

    public void reset(){
        score = 0;
        PlayerPrefs.SetInt("score", score);
    }

}