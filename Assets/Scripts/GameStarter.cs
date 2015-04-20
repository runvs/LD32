﻿using UnityEngine;
using System.Collections;

public class GameStarter : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ChangeLevel()
    {
        Application.LoadLevel("playermove");
    }

    public void StartGame()
    {
        Invoke("ChangeLevel", 0.15f);
        GameProperties.Difficulty = .75f;
    }

    public void OpenLink()
    {
        System.Diagnostics.Process.Start("http://runvs.io");
    }

}
