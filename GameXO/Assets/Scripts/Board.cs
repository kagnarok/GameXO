using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Board : MonoBehaviour {
	public Button m_buttTemp;
	private bool m_isO;

	private List<string> arrBtn = new List<string>();

	private List<Slot> m_allButton = new List<Slot>();
	void Awake(){
		Generate3X3Board();

		arrBtn.Add("0,1,2");
		arrBtn.Add("3,4,5");
		arrBtn.Add("6,7,8");
		arrBtn.Add("0,3,6");
		arrBtn.Add("1,4,7");
		arrBtn.Add("2,5,8");
		arrBtn.Add("0,4,8");
		arrBtn.Add("2,4,6");
	}
	private void Generate3X3Board()
	{
		int index =0;
		for(int i=0;i<3;i++)
		{
			for(int j=0;j<3;j++)
			{
				GameObject go = (GameObject)Instantiate(m_buttTemp.gameObject);
				go.transform.parent = this.transform;
				go.transform.localScale = new Vector3(1,1,1);
				go.GetComponent<Slot>().m_id = index++;
				m_allButton.Add(go.GetComponent<Slot>());
				AddListener(go.GetComponent<Button>());

			}
		}
	}

	private void AddListener(Button b) 
	{
		b.onClick.AddListener(() =>b.GetComponent<Slot>().ButtonEvent(CheckToWin));
	}

	private void CheckToWin(){
	   foreach(string a in arrBtn) {
			string[] p = a.ToString().Split(',');
			if(m_allButton[int.Parse(p[0])].m_clicked && m_allButton[int.Parse(p[1])].m_clicked && m_allButton[int.Parse(p[2])].m_clicked)
			{
				if(m_allButton[int.Parse(p[0])].m_int == m_allButton[int.Parse(p[1])].m_int &&
				    m_allButton[int.Parse(p[1])].m_int == m_allButton[int.Parse(p[2])].m_int){
					Debug.Log("Player Win Is = "+ m_allButton[int.Parse(p[0])].m_name);
				}
			}
		}
	}

}
