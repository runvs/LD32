using UnityEngine;
using System.Collections;

public class PlanetIllumination : MonoBehaviour
{
	public Transform Sun;
	public Transform Planet;
	public Transform Camera;
	public Material PlanetMaterial;

	private const float PI_HALF = Mathf.PI / 2;
	private const float START_POINT = PI_HALF * 3 / 4;
	private const float END_POINT = PI_HALF * 5 / 4;
	private const float BRIGHT_VALUE = 0.8f;
	private const float DIM_VALUE = 0.1f;

	private Color _brightColor = new Color (BRIGHT_VALUE, BRIGHT_VALUE, BRIGHT_VALUE);
	private Color _dimColor = new Color (DIM_VALUE, DIM_VALUE, DIM_VALUE);

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		var a = Planet.position - Sun.position;
		var b = Planet.position - Camera.position;

		var c = Vector3.Dot (a, b);

		var angle = Mathf.Acos (c / a.magnitude / b.magnitude);

		if (angle <= START_POINT)
		{
			PlanetMaterial.SetColor("_EmissionColor", _dimColor);
		}
		else if(angle >= END_POINT)
		{			
			PlanetMaterial.SetColor("_EmissionColor", _brightColor);
		}
		else
		{
			// Transistion zone
			var transitionValue = ((4.0f * angle / Mathf.PI) - 3.0f / 2.0f) * BRIGHT_VALUE;
			var transitionColor = new Color(transitionValue, transitionValue, transitionValue);
			PlanetMaterial.SetColor("_EmissionColor", transitionColor);
		}
	}
}
