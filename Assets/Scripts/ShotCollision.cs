using UnityEngine;
using System.Collections;

public class ShotCollision : MonoBehaviour
{
    public ParticleSystem emitter;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        var ex = Instantiate(emitter, this.transform.position * 0.95f, new Quaternion());
        Destroy(this.gameObject);
    }
}
