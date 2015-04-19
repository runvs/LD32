using System;
using UnityEngine;
using System.Collections;

public class HighscoreDisplay : MonoBehaviour
{

    private UnityEngine.UI.Text _text;


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
        int score = PlayerPrefs.GetInt("highscore", -1000);
        if (score != -1000)
        {
            _text.text = "Highscore  " + score.ToString();
        }
        else
        {
            _text.text = "";
        }
    }
}
