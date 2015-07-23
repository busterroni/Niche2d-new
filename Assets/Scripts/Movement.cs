using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement : MonoBehaviour {
	// Use this for initialization
	Rigidbody2D rb;
	public float speed = 4F;
	public float jumpSpeed;
	public float startX, startY;
	public bool canJump;

	void Start () {
		canJump = true;
		rb = GetComponent<Rigidbody2D> ();
		startX = rb.position.x;
		startY = rb.position.y;
		gameObject.tag = "Player";
	}
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.WindowsPlayer||Application.platform==RuntimePlatform.WindowsEditor) {
			float x = Input.GetAxis ("Horizontal");
			rb.velocity = new Vector2 (x * speed, rb.velocity.y);
			if (Input.GetKey (KeyCode.UpArrow) && canJump) {
				canJump=false;
				rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
				Debug.Log("Jump");
			}
		} else {
			if (Input.GetTouch (0).position.x < Screen.width / 2) {
				//LEFT NO JUMP
				rb.velocity = new Vector2 (-1 * speed, rb.velocity.y);
			} else {
				//RIGHT NO JUMP
				rb.velocity = new Vector2 (speed, rb.velocity.y);
			}
				//JUMP
			if (!(Input.GetTouch (0).position.y < Screen.height / 4 * 3) && canJump) {
				canJump=false;
				rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
				Debug.Log("Jump");
			}
			Input.GetTouch(0).position.x = ;
			Input.GetTouch(0).position.y = null;
		}




		
		//Debug.Log ("Position: "+rb.position);
		if (rb.position.y < -20) {
			rb.position = new Vector2(startX, startY);
		}
	}

	void OnTriggerEnter2D(Collider2D c){
		canJump = true;
	}
	void OnTriggerExit2D(Collider2D c){
		canJump = false;
	}
}
