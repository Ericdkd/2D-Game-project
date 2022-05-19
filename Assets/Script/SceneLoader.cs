using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //[SerializeField] InputField playerNameInput;
    [SerializeField] InputField playerNameInput;
   
    //public InputField playerName;

    void Start(){  }

    // Update is called once per frame
    void Update(){ }

    public void PlayGame() {
        string s = playerNameInput.text;
        PersistentData.Instance.SetName(s);
        //Name.playerNameString = ("Player Name: " + playerName.text);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void highscore()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void Instructions()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void LoadScene(int level)
    {
        //SceneManager.LoadScene("2d project scene");
        SceneManager.LoadScene(level);
        
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu Scene");
    }


}