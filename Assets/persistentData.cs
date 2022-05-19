using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class persistentData : MonoBehaviour
{
public static PersistentData Instance;
    [SerializeField] string playerNameText;
void Start()
    {
playerNameText = PlayerPrefs.GetString("name");
}
public void DisplayName()
    {
        playerNameText = "Name: " + playerNameText;
        PlayerPrefs.SetString("name", playerNameText);

    }
void Update()
    {

        PlayerPrefs.SetString("name", playerNameText);
        DisplayName();

    }
}