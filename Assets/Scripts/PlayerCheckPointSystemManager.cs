using UnityEngine;
using System.Collections;

public class PlayerCheckPointSystemManager : MonoBehaviour {
	private static float counter = 0F;
	public int hp;
	private static float cpCounter = 0F;

	public static void checkPoint(){
		counter += .1F;
		cpCounter = counter;
	}
	public static float getCounter(){
		return counter;
	}
	public static void startLevel(){
		counter = 0F;
	}
	public static void cpReset(){
		counter = cpCounter;
	}
}
