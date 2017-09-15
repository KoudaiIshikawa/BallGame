using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	private void FixedUpdate ()
	{
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		rigidbody.AddForce (x * 10, 0, z * 10);
	}
}
