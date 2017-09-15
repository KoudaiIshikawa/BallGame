using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FailButtonController : MonoBehaviour
{
	
	public Button RetryButton ;
	private void Update ()
	{
		if (Input.GetMouseButtonDown (0))
		{
			SceneManager.LoadScene (0);
		}
	}	
	private void Start () 
		{
			// 開始時に表示を消す
			RetryButton.gameObject.SetActive(false);
		}

	public void ShowRetryButton ()
		{
			RetryButton.gameObject.SetActive(true);	
		}
}
