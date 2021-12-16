using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public static MenuScene menuScene;
    public TMP_InputField inputField;
        
    public string playerName;

    private void Awake()
    {
        if (menuScene == null)
        {
            menuScene = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerName()
    {
        playerName = inputField.text;

        SceneManager.LoadSceneAsync("main");
    }

}
