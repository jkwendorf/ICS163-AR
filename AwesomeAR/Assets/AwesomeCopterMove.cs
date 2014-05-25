
// Jason Heckard  		84851006
// Jonathan Wendorf  	
// Eli 

using UnityEngine;
using System.Collections;

public class AwesomeCopterMove : MonoBehaviour 
{
	
	public int copterState;
	// copter state 0 = travel from (100, 100, 100) to (100, 100, 0)
	// copter state 1 = travel from (100, 100, 0) to (0, 0, 0) while rotate(5)
	// copter state 2 = !active for count to 30
	
	int sleepCount;
	
	public int xFar;
	public int yFar;
	public int zFar;
	
	public int xNear;
	public int yNear;
	public int zNear;
	
	public GameObject copter;
	public GameObject rotor;

	// Use this for initialization
	void Start () 
	{
		transform.position = new Vector3(10, 10, 10);
		
		copterState = 0;
		
		xFar = 10;
		yFar = 10;
		zFar = 10;
		
		int xNear = 0;
		int yNear = 0;
		int zNear = 0;
		
		sleepCount = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(copterState == 0)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.1f);
			
			
			if( transform.position.z < 0 )
			{
				transform.position = new Vector3(xFar, yFar, zNear);
				copterState = 1;
			}
		}
		
		if(copterState == 1)
		{
			transform.position = new Vector3(transform.position.x -0.1f, transform.position.y - 0.1f, zNear);
			transform.Rotate(Vector3.up, 5);
			
			if(transform.position.x < xNear)
			{
				copterState = 2;
				// transform.position = new Vector3(xFar, yFar, zFar);
				
				transform.position = new Vector3(xNear, yNear, zNear);
				copter.SetActive(false);
				rotor.SetActive(false);
			}
		}
		
		
		if(copterState == 2)
		{
			if(sleepCount < 30)
			{
				sleepCount++;
			}
			
			else
			{
				sleepCount = 0;
				copterState = 0;
				transform.position = new Vector3(xFar, yFar, zFar);
				copter.SetActive(true);
				rotor.SetActive(true);
				transform.localEulerAngles = new Vector3(0, 0, -1);
				
				// transform.rotation = new Quaternion(0,0,-1,0);
			}
		}
		
	}
}
