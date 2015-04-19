using UnityEngine;
using System.Collections;

public class SearchLightPulse : MonoBehaviour
{
	public float MaxValue = 5.0f;
	public float MinValue = 1.0f;
	public float TimeScale = 3.0f;
	
	// Update is called once per frame
	void Update()
	{
		var light = GetComponent<Light>();

		var normalizedIntensity = (Mathf.Sin(Time.realtimeSinceStartup * TimeScale) + 1.0f) / 2.0f;
		light.intensity = normalizedIntensity * (MaxValue - MinValue) + MinValue;
	}
}
