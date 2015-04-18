using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    //private Transform _t;
    public GameObject Rotator;

	// Use this for initialization
	void Start ()
	{
	   // _t = this.transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (Input.GetAxis("Horizontal") > 0)
	    {
	        MoveRight();
	    }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            MoveLeft();
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            MoveDown();
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            MoveUp();
        }

	}

    private void MoveDown()
    {
        Rotator.transform.Rotate(new Vector3(1, 0, 0), 2.25f);
    }

    private void MoveUp()
    {
        Rotator.transform.Rotate(new Vector3(1, 0, 0), -2.25f);
    }

    private void MoveLeft()
    {
        Rotator.transform.Rotate(new Vector3(0, 0, 1), 2.25f);
    }

    private void MoveRight()
    {
        Rotator.transform.Rotate(new Vector3(0, 0, 1), -2.25f);
    }


}
