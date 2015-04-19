using UnityEngine;
using System.Collections;

public class PlayerShooter : MonoBehaviour
{

    public GameObject ShotTemplate;
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
        GameObject i = Instantiate(ShotTemplate, pos, Quaternion.Euler(0, 0, 0)) as GameObject;
        _inputTimer += 0.75f;
    }
}
