using UnityEngine;
using System.Collections;

public class AwesomeRotorSpin : MonoBehaviour 
{
	public float rotate;
	
	// Use this for initialization
	void Start () 
	{
		rotate = 800.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*
		if(rotate < 360.0f)
		{
			rotate += 2;	
		}
		else
		{
			rotate = 0f;
		}
		*/
		
		transform.Rotate(Vector3.forward, rotate * Time.deltaTime);
	}
}
