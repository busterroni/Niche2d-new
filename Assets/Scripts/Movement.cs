using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	// Use this for initialization
	Rigidbody2D rb;
	public float speed = 4F;
	public bool canJump;
	
	void Start (){
		canJump = true;
		rb = GetComponent<Rigidbody2D> ();
	}
	// Update is called once per frame
	void Update (){
		float x = Input.GetAxis ("Horizontal");
		//float y = Input.GetAxis ("Vertical");
		rb.velocity = new Vector2 (x * speed, rb.velocity.y);
		if (Input.GetKeyDown (KeyCode.UpArrow) && canJump) {
			canJump = false;
			rb.velocity = new Vector2 (rb.velocity.x, 7);
			Debug.Log ("UP");
		}

		if (rb.position.y < -10) {
			rb.position=new Vector2(3, 4);
		}
	}

	void OnTriggerEnter2D (Collider2D c){
		canJump = true;
	}

	void OnTriggerExit2D (Collider2D c){
		canJump = false;
	}
}