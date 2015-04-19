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
            HighscoreScript.AddHighscore(2);
            Debug.Log("hit!");
            Destroy(this.gameObject);
        }
    }

    void Wander()
    {

    }
}
