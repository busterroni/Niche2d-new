using UnityEngine;
using System.Collections;

public class ColorWhiteLevel1 : MonoBehaviour {
	public Color colorStart;
	public Color colorEnd;
	public float duration = 1.0F;
	public Renderer rend;
	void Start() {
		rend = GetComponent<Renderer>();
	}
	void Update() {
		float lerp = PlayerCheckPointSystemManager.getCounter();
		rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
	}
}
