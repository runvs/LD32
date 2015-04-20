using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject.FindGameObjectWithTag("Highscore");
        InvokeRepeating("Wander", 2, 20);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.tag == "Laser")
        {
            uint score = 1;
            if (GameProperties.Difficulty > 0.75f)
            {
                score += 1;
            }
            if (GameProperties.Difficulty > 1.0f)
            {
                score += 1;
            }
            HighscoreScript.AddHighscore(score);
            Debug.Log("hit!");
            Destroy(this.gameObject);
        }
    }

    void Wander()
    {

    }
}
