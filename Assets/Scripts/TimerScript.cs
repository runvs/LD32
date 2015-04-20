using System;
using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour
{

    private UnityEngine.UI.Text _text;
    private float _timer = 50;
    // Use this for initialization
    void Start()
    {
        _text = gameObject.GetComponent<UnityEngine.UI.Text>() as UnityEngine.UI.Text;
        if (_text == null)
        {
            throw new NullReferenceException("Error: GuiText not fond");

        }
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = _timer.ToString("F1");
        _timer -= Time.deltaTime;

        if (_timer < 10)
        {
            float r = 105.0f / 255.0f;
            float g = 35.0f / 255.0f;
            float b = 15.0f / 255.0f;
            if (_text.name == "TimerText2") // make it glow red
            {
                _text.color = new Color(r, g, b, 1.0f);
            }

        }
        if (_timer < 0)
        {
            EndThisGame();
        }

    }

    private void EndThisGame()
    {
        int score = checked((int)HighscoreScript.GetScore());

        int scoreSaved = PlayerPrefs.GetInt("highscore", -1000);
        if (scoreSaved < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }

        Application.LoadLevel("Menu");
    }

}
