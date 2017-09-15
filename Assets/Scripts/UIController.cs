using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour 
{
	public Text GameClearLabel;

	private void Start () 
	{
		// 開始時に表示を消す
		GameClearLabel.gameObject.SetActive(false);	
	}

	public void ShowGameClearLabel()
	{
		// 開始時に表示する
		GameClearLabel.gameObject.SetActive(true);	
	}
}