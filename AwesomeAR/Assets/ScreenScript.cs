using UnityEngine;
using System.Collections;

public class ScreenScript : MonoBehaviour {

	public Font myFont;
	bool showLabel;

	public int rotation = 90;
	Vector2 pivotPoint;

	int box_X = 150;
	int box_Y = 150;
	int quit_X = 360;

	int top = 1100;
	int left = 150;
	int widthMiddle = 305;
	int heightMiddle = 1255;
	int bottom = 1410;
	int right = 460;
	int farRight = 615;

	// Use this for initialization
	void Start () {
		showLabel = false;
		pivotPoint = new Vector2(widthMiddle, heightMiddle);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI()
	{
		GUIUtility.RotateAroundPivot(rotation, pivotPoint);

		GUIStyle myStyle = new GUIStyle(GUI.skin.button);
		myStyle.font = myFont;

		if(GUI.Button(new Rect(left, top, box_X, box_Y), "1", myStyle))
		{
			GameManager.instance.SetGameToken(1);
		}
		if(GUI.Button(new Rect(widthMiddle, top, box_X, box_Y), "2", myStyle))
		{
			GameManager.instance.SetGameToken(2);
		}
		if(GUI.Button(new Rect(right, top, box_X, box_Y), "3", myStyle))
		{
			GameManager.instance.SetGameToken(3);
		}
		if(GUI.Button(new Rect(left, heightMiddle, box_X, box_Y), "4", myStyle))
		{
			GameManager.instance.SetGameToken(4);
		}
		if(GUI.Button(new Rect(widthMiddle, heightMiddle, box_X, box_Y), "5", myStyle))
		{
			GameManager.instance.SetGameToken(5);
		}
		if(GUI.Button(new Rect(right, heightMiddle, box_X, box_Y), "6", myStyle))
		{
			GameManager.instance.SetGameToken(6);
		}
		if(GUI.Button(new Rect(left, bottom, box_X, box_Y), "7", myStyle))
		{
			GameManager.instance.SetGameToken(7);
		}
		if(GUI.Button(new Rect(widthMiddle, bottom, box_X, box_Y), "8", myStyle))
		{
			GameManager.instance.SetGameToken(8);
		}
		if(GUI.Button(new Rect(right, bottom, box_X, box_Y), "9", myStyle))
		{
			GameManager.instance.SetGameToken(9);
		}
		if(GUI.Button(new Rect(farRight, top, quit_X, box_Y), "Reset", myStyle))
		{
			GameManager.instance.ResetGame();
		}
		if(GUI.Button(new Rect(farRight, heightMiddle, quit_X, box_Y), "Quit", myStyle))
		{
			Application.Quit();
		}
	}
}
