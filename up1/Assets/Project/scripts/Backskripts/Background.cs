using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {
	private AudioSource Rebornbeep;
	public static float beep1 = 0;
	void Start () {

		var weight = Camera.main.orthographicSize * 1.5f;  //Ширина по камере
		var height = weight * Screen.height / Screen.height * 5f; //Высота длиннее камеры в 5 раз
		if (gameObject.name == "Backgroundmo") { //Если Бэк
			transform.localScale = new Vector3 (weight, height, 0); //Ширину по размеру
		}
		Rebornbeep = GetComponent<AudioSource> (); //Когда воскресли пибнутть

	}

	void Update (){
		if (Restore_player.flag_voskres == 1 && beep1 == 1) {  
			Rebornbeep.Play (); //БИИИП
		
			beep1 = 0;


		
		}
	}
	

}
