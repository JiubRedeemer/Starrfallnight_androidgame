using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsFalling : MonoBehaviour {
	private float time = 11; //Частота спавна
	private float timebaza = 11; //База
	private float fallspeed = 3f;//Скорость падения
	public static int flag_podbor = 1; //Взял
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		



		if (transform.position.y < -6f) {
			Destroy (gameObject); //Если ушел за карту уничтожить


		}

		if (flag_podbor == 0) { //Взял = уничтожить
			Destroy (gameObject);
			flag_podbor = 1;
		}

		if (!player.lose) {transform.position -= new Vector3 (0, fallspeed * Time.deltaTime, 0);
		}
	}

}
