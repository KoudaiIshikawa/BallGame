using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FailController : MonoBehaviour 
{
	// UIController を参照する
	public UIFailController UIFailController;
	public FailButtonController FailButtonController;

	// Trigger との接触時に呼ばれる Callback
	private void OnTriggerEnter (Collider hit)
	{
		// 接触対象はPlayerタグかどうか
		if (hit.CompareTag ("Player")) 
		{
			// Rigidbody を停止させる
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			// ゲームクリアを表示する
			UIFailController.ShowGameFailedLabel();
			FailButtonController.ShowRetryButton();
		}
	}
}




