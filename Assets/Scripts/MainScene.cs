using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainScene : MonoBehaviour
{
    public TextMeshProUGUI displayPlayerName;

    public void Awake()
    {
        displayPlayerName.text = MenuScene.menuScene.playerName + " has hi-Score: ";
    }

}
