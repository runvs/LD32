using UnityEngine;
using System.Collections;

public class SunMovement : MonoBehaviour
{

    public float Distance = 1.0f;
    public float Inclination = 10.0f;   // in degree
    public float RotationFrequency = 0.8f;
    private float _timeTotal = 0;

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        float t = Time.fixedDeltaTime;
        _timeTotal += t;

        float x = Distance * Mathf.Sin(RotationFrequency * _timeTotal / Mathf.PI) *
                                    Mathf.Cos(Mathf.Deg2Rad * Inclination);

        float z = Distance * Mathf.Cos(RotationFrequency * _timeTotal / Mathf.PI) *
                                    1.0f;
        float y = Distance * Mathf.Sin((RotationFrequency * _timeTotal + 0.25f) / Mathf.PI) *
                                    Mathf.Sin(Mathf.Deg2Rad * Inclination);
        this.transform.position = new Vector3(x, y, z);

		var rotation = Quaternion.FromToRotation(new Vector3(0, 0, -1), this.transform.position);
		this.transform.rotation = rotation;
    }
}
