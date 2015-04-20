using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighscoreScript : MonoBehaviour
{

    private Text _text;
    private static uint _score = 0;

    // Use this for initialization
    void Start()
    {
        _score = 0;
        _text = gameObject.GetComponent<UnityEngine.UI.Text>() as UnityEngine.UI.Text;
        if (_text == null)
        {
            throw new NullReferenceException("Error: GuiText not fond");

        }
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = _score.ToString();
    }

    public static void AddHighscore(uint score)
    {
        _score += score;
    }

    public static uint GetScore()
    {
        return _score;
    }
}
