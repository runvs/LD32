using UnityEngine;
using System.Collections;

public class particledeleter : MonoBehaviour {

    private ParticleSystem ps;

    // Use this for initialization
    void Start () 
    {
        ps = this.gameObject.GetComponent<ParticleSystem>();
    }
    
    // Update is called once per frame
    void Update () 
    {
        if (ps)
        {
            if (!ps.IsAlive())
            {
                Destroy(gameObject);
            }
        }
    
    }
}
