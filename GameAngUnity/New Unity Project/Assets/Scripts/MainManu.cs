﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManu : MonoBehaviour {

    public string startLevel;
    public string levelSelect;

    public void NewGame()
    {
        Application.LoadLevel(startLevel);
    }

    public void LevelSelect()
    {
        Application.LoadLevel(levelSelect);
    }

    public void QuitGame()
    {
        Debug.Log("Game exited.");
        Application.Quit();
    }
}
