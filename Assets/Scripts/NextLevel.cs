using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {
	
	// Use this for initialization
	void OnTriggerEnter2D (Collider2D c) {
		if (c.tag=="Player") {
			Debug.Log (c.tag+" End Level");

			Application.LoadLevel("MainMenu");
		}
	}
}
