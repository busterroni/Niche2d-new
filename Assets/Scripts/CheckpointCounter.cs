using UnityEngine;
using System.Collections;


public class CheckpointCounter : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D c){
		PlayerCheckPointSystemManager.checkPoint ();
		Debug.Log (PlayerCheckPointSystemManager.getCounter ());
		Destroy (this);
	}
}
