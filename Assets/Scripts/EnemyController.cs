using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		InvokeRepeating("Wander", 2, 20);
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}
	
	void Wander()
    {
        
	}
}
