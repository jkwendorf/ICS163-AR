using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour 
{
	public Transform carMesh;

 	public int radius = 2;
	public float currentAngle = 0f;
	public float targetAngle = 0f;	
	float oneDegRad = (3.1415926f / 180f);
	
	// Use this for initialization
	void Start () 
	{
		rigidbody.velocity = new Vector3(0, 0, 10);
		
		transform.Rotate(Vector3.up, 180);
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*
if(transform.position.z > 20)
{
transform.position = new Vector3(transform.position.x, transform.position.y, -20) ;
}
*/
		
		if(currentAngle < 6.28)
		{
			currentAngle += oneDegRad;
		}
		else
		{
			currentAngle = 0;
		}
		
		float xLoc = Mathf.Cos(currentAngle) * radius;
		float zLoc = (Mathf.Sin (currentAngle) * radius);
		
		transform.Rotate(Vector3.up, -1);
		
		transform.position = new Vector3(xLoc, 1f, zLoc);
	}
}