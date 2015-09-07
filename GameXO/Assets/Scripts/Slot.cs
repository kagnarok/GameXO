using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Slot : MonoBehaviour {

	public int m_id;
//	public bool m_isO;
	public bool m_clicked;
	public string m_name;
	public int m_int;
	public delegate void boardCallback();
	private boardCallback m_callback;

	public void ButtonEvent(boardCallback b)
	{
		if(!m_clicked){
			ChangeXO();
			b();
		}
	}

	private void ChangeXO()
	{
		m_clicked = true;
		if(GameManager.m_oneOrTwo)
		{
			ChangeToX();
		}
		else
		{
			ChangeToO();
		}
		GameManager.m_oneOrTwo = !GameManager.m_oneOrTwo;
	}

	private void ChangeToX()
	{
		m_int = 1;
		GetComponent<Image>().color = Color.blue;
		m_name = "Player2";
	}
	private void ChangeToO()
	{
		m_int = 0;
		GetComponent<Image>().color = Color.red;
		m_name = "Player1";
	}
}
