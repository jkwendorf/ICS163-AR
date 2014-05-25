using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public GameObject O_1;
	public GameObject O_2;
	public GameObject O_3;
	public GameObject O_4;
	public GameObject O_5;
	public GameObject O_6;
	public GameObject O_7;
	public GameObject O_8;
	public GameObject O_9;
	public GameObject X_1;
	public GameObject X_2;
	public GameObject X_3;
	public GameObject X_4;
	public GameObject X_5;
	public GameObject X_6;
	public GameObject X_7;
	public GameObject X_8;
	public GameObject X_9;

	public GameObject horizontalLineR1;
	public GameObject horizontalLineR2;
	public GameObject horizontalLineR3;
	public GameObject verticalLineC1;
	public GameObject verticalLineC2;
	public GameObject verticalLineC3;
	public GameObject DiagonalLine1;
	public GameObject DiagonalLine2;

	Vector3 hlr1StartPosition;
	Vector3 hlr2StartPosition;
	Vector3 hlr3StartPosition;

	Vector3 vlc1StartPosition;
	Vector3 vlc2StartPosition;
	Vector3 vlc3StartPosition;

	Vector3 dl1StartPosition;
	Vector3 dl2StartPosition;

	public Font gameFont;
	GUIStyle gameStyle;
	int player = 0;
	string message;
	string winMessage;

	bool set1, set2, set3, set4, set5, set6, set7, set8, set9;
	bool p1hit1, p1hit2, p1hit3, p1hit4, p1hit5, p1hit6, p1hit7, p1hit8, p1hit9;
	bool p2hit1, p2hit2, p2hit3, p2hit4, p2hit5, p2hit6, p2hit7, p2hit8, p2hit9;

	// Use this for initialization
	void Start () {
		instance = this;
		player = 1;
		set1 = false;
		set2 = false;
		set3 = false;
		set4 = false;
		set5 = false;
		set6 = false;
		set7 = false;
		set8 = false;
		set9 = false;



		p1hit1 = false;
		p1hit2 = false;
		p1hit3 = false;
		p1hit4 = false;
		p1hit5 = false;
		p1hit6 = false;
		p1hit7 = false;
		p1hit8 = false;
		p1hit9 = false;

		p2hit1 = false;
		p2hit2 = false;
		p2hit3 = false;
		p2hit4 = false;
		p2hit5 = false;
		p2hit6 = false;
		p2hit7 = false;
		p2hit8 = false;
		p2hit9 = false;

		verticalLineC1.SetActive(false);
		vlc1StartPosition = verticalLineC1.transform.position;

		verticalLineC2.SetActive(false);
		vlc2StartPosition = verticalLineC2.transform.position;

		verticalLineC3.SetActive(false);
		vlc3StartPosition = verticalLineC3.transform.position;

		horizontalLineR1.SetActive(false);
		hlr1StartPosition = horizontalLineR1.transform.position;

		horizontalLineR2.SetActive(false);
		hlr2StartPosition = horizontalLineR2.transform.position;

		horizontalLineR3.SetActive(false);
		hlr3StartPosition = horizontalLineR3.transform.position;

		DiagonalLine1.SetActive(false);
		dl1StartPosition = DiagonalLine1.transform.position;

		DiagonalLine2.SetActive(false);
		dl2StartPosition = DiagonalLine2.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		message = "It's player " + player + "'s turn";

		// player 1 win conditions

		if(p1hit1 == true && p1hit2 == true && p1hit3 == true)
		{
			message = "Game Over";
			winMessage = "Player 1 has won the game!";
			horizontalLineR1.SetActive(true);
			horizontalLineR1.rigidbody.useGravity = true;

		}
		else if(p1hit4 == true && p1hit5 == true && p1hit6 == true)
		{
			message = "Game Over";
			winMessage = "Player 1 has won the game!";
			horizontalLineR2.SetActive(true);
			horizontalLineR2.rigidbody.useGravity = true;
		}
		else if(p1hit7 == true && p1hit8 == true && p1hit9 == true)
		{
			message = "Game Over";
			winMessage = "Player 1 has won the game!";
			horizontalLineR3.SetActive(true);
			horizontalLineR3.rigidbody.useGravity = true;
		}
		else if(p1hit1 == true && p1hit4 == true && p1hit7 == true)
		{
			message = "Game Over";
			winMessage = "Player 1 has won the game!";
			verticalLineC1.SetActive(true);
			verticalLineC1.rigidbody.useGravity = true;
		}
		else if(p1hit2 == true && p1hit5 == true && p1hit8 == true)
		{
			message = "Game Over";
			winMessage = "Player 1 has won the game!";
			verticalLineC2.SetActive(true);
			verticalLineC2.rigidbody.useGravity = true;
		}
		else if(p1hit3 == true && p1hit6 == true && p1hit9 == true)
		{
			message = "Game Over";
			winMessage = "Player 1 has won the game!";
			verticalLineC3.SetActive(true);
			verticalLineC3.rigidbody.useGravity = true;
		}
		else if(p1hit1 == true && p1hit5 == true && p1hit9 == true)
		{
			message = "Game Over";
			winMessage = "Player 1 has won the game!";
			DiagonalLine1.SetActive(true);
			DiagonalLine1.rigidbody.useGravity = true;
		}
		else if(p1hit3 == true && p1hit5 == true && p1hit7 == true)
		{
			message = "Game Over";
			winMessage = "Player 1 has won the game!";
			DiagonalLine2.SetActive(true);
			DiagonalLine2.rigidbody.useGravity = true;
		}

		// player 2 win conditions

		else if(p2hit1 == true && p2hit2 == true && p2hit3 == true)
		{
			message = "Game Over";
			winMessage = "Player 2 has won the game!";
			horizontalLineR1.SetActive(true);
			horizontalLineR1.rigidbody.useGravity = true;
		}
		else if(p2hit4 == true && p2hit5 == true && p2hit6 == true)
		{
			message = "Game Over";
			winMessage = "Player 2 has won the game!";
			horizontalLineR2.SetActive(true);
			horizontalLineR2.rigidbody.useGravity = true;
		}
		else if(p2hit7 == true && p2hit8 == true && p2hit9 == true)
		{
			message = "Game Over";
			winMessage = "Player 2 has won the game!";
			horizontalLineR3.SetActive(true);
			horizontalLineR3.rigidbody.useGravity = true;
		}
		else if(p2hit1 == true && p2hit4 == true && p2hit7 == true)
		{
			message = "Game Over";
			winMessage = "Player 2 has won the game!";
			verticalLineC1.SetActive(true);
			verticalLineC1.rigidbody.useGravity = true;
		}
		else if(p2hit2 == true && p2hit5 == true && p2hit8 == true)
		{
			message = "Game Over";
			winMessage = "Player 2 has won the game!";
			verticalLineC2.SetActive(true);
			verticalLineC2.rigidbody.useGravity = true;
		}
		else if(p2hit3 == true && p2hit6 == true && p2hit9 == true)
		{
			message = "Game Over";
			winMessage = "Player 2 has won the game!";
			verticalLineC3.SetActive(true);
			verticalLineC3.rigidbody.useGravity = true;
		}
		else if(p2hit1 == true && p2hit5 == true && p2hit9 == true)
		{
			message = "Game Over";
			winMessage = "Player 2 has won the game!";
			DiagonalLine1.SetActive(true);
			DiagonalLine1.rigidbody.useGravity = true;
		}
		else if(p2hit3 == true && p2hit5 == true && p2hit7 == true)
		{
			message = "Game Over";
			winMessage = "Player 2 has won the game!";
			DiagonalLine2.SetActive(true);
			DiagonalLine2.rigidbody.useGravity = true;
		}

		else
		{
			if(set1 == true && set2 == true && set3 == true && set4 == true && set5 == true && set6 == true && set7 == true && set8 == true && set9 == true)
			{
				message = "Game Over";
				winMessage = "Its a Cats Game!"; 
			}
		}

	}

	void OnGUI()
	{
		gameStyle = new GUIStyle();
		gameStyle.font = gameFont;
		gameStyle.normal.textColor = Color.white;

		GUIUtility.RotateAroundPivot(90, new Vector2(1100, 0));

		GUI.Label(new Rect(1100, 0, 300, 50), message, gameStyle);
		GUI.Label(new Rect(1100, 120, 300, 50), winMessage, gameStyle);
	}

	// Switches turns for the player
	void ChangeTurn()
	{
		player++;

		if(player > 2)
			player = 1;
	}

	// Resets the game to it's default state
	public void ResetGame()
	{
		// Resets all pieces to default/hidden
		O_1.SetActive(false);
		O_2.SetActive(false);
		O_3.SetActive(false);
		O_4.SetActive(false);
		O_5.SetActive(false);
		O_6.SetActive(false);
		O_7.SetActive(false);
		O_8.SetActive(false);
		O_9.SetActive(false);
		X_1.SetActive(false);
		X_2.SetActive(false);
		X_3.SetActive(false);
		X_4.SetActive(false);
		X_5.SetActive(false);
		X_6.SetActive(false);
		X_7.SetActive(false);
		X_8.SetActive(false);
		X_9.SetActive(false);

		// Set flags to false
		set1 = false;
		set2 = false;
		set3 = false;
		set4 = false;
		set5 = false;
		set6 = false;
		set7 = false;
		set8 = false;
		set9 = false;

		p1hit1 = false;
		p1hit2 = false;
		p1hit3 = false;
		p1hit4 = false;
		p1hit5 = false;
		p1hit6 = false;
		p1hit7 = false;
		p1hit8 = false;
		p1hit9 = false;
		
		p2hit1 = false;
		p2hit2 = false;
		p2hit3 = false;
		p2hit4 = false;
		p2hit5 = false;
		p2hit6 = false;
		p2hit7 = false;
		p2hit8 = false;
		p2hit9 = false;



		// Choose a random player
		player = 1;

		winMessage = "";

		verticalLineC1.SetActive(false);
		verticalLineC1.rigidbody.useGravity = false;
		verticalLineC1.transform.position = vlc1StartPosition;

		verticalLineC2.SetActive(false);
		verticalLineC2.rigidbody.useGravity = false;
		verticalLineC2.transform.position = vlc2StartPosition;

		verticalLineC3.SetActive(false);
		verticalLineC3.rigidbody.useGravity = false;
		verticalLineC3.transform.position = vlc3StartPosition;

		horizontalLineR1.SetActive(false);
		horizontalLineR1.rigidbody.useGravity = false;
		horizontalLineR1.transform.position = hlr1StartPosition;

		horizontalLineR2.SetActive(false);
		horizontalLineR2.rigidbody.useGravity = false;
		horizontalLineR2.transform.position = hlr2StartPosition;

		horizontalLineR3.SetActive(false);
		horizontalLineR3.rigidbody.useGravity = false;
		horizontalLineR3.transform.position = hlr3StartPosition;

		DiagonalLine1.SetActive(false);
		DiagonalLine1.rigidbody.useGravity = false;
		DiagonalLine1.transform.position = dl1StartPosition;

		DiagonalLine2.SetActive(false);
		DiagonalLine2.rigidbody.useGravity = false;
		DiagonalLine2.transform.position = dl2StartPosition;
	}

	// Places a game token on the specified slot
	// The GameManager knows which player is going and will place the correct piece on the board
	public void SetGameToken(int slot)
	{
		switch(player)
		{
		// If Player 1
		case 1:
			if(slot == 1 && !set1)
			{
				X_1.SetActive(true);
				set1 = true;
				p1hit1 = true;
				ChangeTurn ();
			}
			else if(slot == 2 && !set2)
			{
				X_2.SetActive(true);
				set2 = true;
				p1hit2 = true;
				ChangeTurn ();
			}
			else if(slot == 3 && !set3)
			{
				X_3.SetActive(true);
				set3 = true;
				p1hit3 = true;
				ChangeTurn ();
			}
			else if(slot == 4 && !set4)
			{
				X_4.SetActive(true);
				set4 = true;
				p1hit4 = true;
				ChangeTurn ();
			}
			else if(slot == 5 && !set5)
			{
				X_5.SetActive(true);
				set5 = true;
				p1hit5 = true;
				ChangeTurn ();
			}
			else if(slot == 6 && !set6)
			{
				X_6.SetActive(true);
				set6 = true;
				p1hit6 = true;
				ChangeTurn ();
			}
			else if(slot == 7 && !set7)
			{
				X_7.SetActive(true);
				set7 = true;
				p1hit7 = true;
				ChangeTurn ();
			}
			else if(slot == 8 && !set8)
			{
				X_8.SetActive(true);
				set8 = true;
				p1hit8 = true;
				ChangeTurn ();
			}
			else if(slot == 9 && !set9)
			{
				X_9.SetActive(true);
				set9 = true;
				p1hit9 = true;
				ChangeTurn ();
			}

			break;
			// If Player 2
		case 2:	
			if(slot == 1 && !set1)
			{
				O_1.SetActive(true);
				set1 = true;
				p2hit1 = true;
				ChangeTurn ();
			}
			else if(slot == 2 && !set2)
			{
				O_2.SetActive(true);
				set2 = true;
				p2hit2 = true;
				ChangeTurn ();
			}
			else if(slot == 3 && !set3)
			{
				O_3.SetActive(true);
				set3 = true;
				p2hit3 = true;
				ChangeTurn ();
			}
			else if(slot == 4 && !set4)
			{
				O_4.SetActive(true);
				set4 = true;
				p2hit4 = true;
				ChangeTurn ();
			}
			else if(slot == 5 && !set5)
			{
				O_5.SetActive(true);
				set5 = true;
				p2hit5 = true;
				ChangeTurn ();
			}
			else if(slot == 6 && !set6)
			{
				O_6.SetActive(true);
				set6 = true;
				p2hit6 = true;
				ChangeTurn ();
			}
			else if(slot == 7 && !set7)
			{
				O_7.SetActive(true);
				set7 = true;
				p2hit7 = true;
				ChangeTurn ();
			}
			else if(slot == 8 && !set8)
			{
				O_8.SetActive(true);
				set8 = true;
				p2hit8 = true;
				ChangeTurn ();
			}
			else if(slot == 9 && !set9)
			{
				O_9.SetActive(true);
				set9 = true;
				p2hit9 = true;
				ChangeTurn ();
			}
			break;
		}
	}
}
