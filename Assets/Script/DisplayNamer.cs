using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNamer : MonoBehaviour
{
     public Text obj_text;
    public InputField display;

    void Start()
    {
        obj_text.text = PlayerPrefs.GetString("user_name");
    }

    public void Create(){
        obj_text.text = display.text;
        PlayerPrefs.SetString("user_name", obj_text.text);
        PlayerPrefs.Save();
    }

    public void GetString(){
        PlayerPrefs.GetString("Thank you for playing the game", obj_text.text);
    }
}
