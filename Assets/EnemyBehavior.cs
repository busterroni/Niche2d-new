using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {
	GameObject player;
	GameObject enemy;
	Rigidbody2D rb;
	Vector2 thrust;

	//0=left
	//1=right
	int direction=0;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		enemy = GameObject.Find ("enemy");
		rb = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		if (player.transform.position.x - enemy.transform.position.x < 10 && enemy.transform.position.x - player.transform.position.x > 0) {
			enemy.transform.Translate (Vector2.left * .5f * Time.deltaTime);
			direction=0;
		}
		else if (enemy.transform.position.x - player.transform.position.x < 10 && enemy.transform.position.x - player.transform.position.x > 0) {
			enemy.transform.Translate (Vector2.right * .5f * Time.deltaTime);
			direction=1;
		}
	}
	void OnTriggerEnter2D (Collider2D c){
		if (c.name == "enemy") {
			if(direction==0){
				thrust=Vector2.left;
			}
			else{
				thrust=Vector2.right;
			}
			for(int i=1; i<10; i++){
				player.transform.Translate (thrust * 1);
			}
			Debug.Log ("hit");
		}

			//player.transform.position = new Vector2 (player.transform.position.x - 5, player.transform.position.y);
	}
}
