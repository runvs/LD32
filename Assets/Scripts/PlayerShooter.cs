using UnityEngine;
using System.Collections;

public class PlayerShooter : MonoBehaviour
{

    public GameObject ShotTemplate;
    public ParticleSystem emitter;
    private float _inputTimer = 0.0f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_inputTimer > 0)
        {
            _inputTimer -= Time.deltaTime;
        }
        else
        {
            if (Input.GetButton("Fire1"))
            {
                Fire();
            }
        }

    }

    private void Fire()
    {
        Vector3 pos = this.transform.position;
        pos *= 0.85f;
        GameObject i = Instantiate(ShotTemplate, pos, Quaternion.FromToRotation(new Vector3(0, -1, 0), -pos.normalized)) as GameObject;  // correct rotation
        i.GetComponent<Rigidbody>().velocity = -pos.normalized * 1.5f;  // correct velocity
        _inputTimer += 0.75f;
    }
}
