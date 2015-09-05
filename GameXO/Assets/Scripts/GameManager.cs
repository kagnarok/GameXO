using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private GAMESTATE m_gameState;
	// Use this for initialization
	void Awake () {
		InitGame();
	}
	
	private void InitGame()
	{
		SetGameState(GAMESTATE.INIT);
		CreateBoardGameWithSize(BOARDSIZE.S3X3);
		CreatePlayerData();
		RandomUserFirstPlay();
		CreateUIForFirstPlayerChooseXOrO();
	}

	private void SetGameState(GAMESTATE state)
	{
		m_gameState = state;
	}

	private void CreateBoardGameWithSize(BOARDSIZE size)
	{

	}

	private void CreatePlayerData()
	{
	}

	private void RandomUserFirstPlay()
	{
	}

	private void CreateUIForFirstPlayerChooseXOrO()
	{

	}
}
