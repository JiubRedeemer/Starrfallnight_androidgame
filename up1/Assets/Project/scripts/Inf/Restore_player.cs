using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Restore_player : MonoBehaviour {
	public GameObject restart; //Объект кнопка рестарта
	public GameObject restorepl; //Кнопка воскреса
	public static float flag_voskres = 0; //Флаг = 0 

	void Start (){
		
	}


	public void OnClick () { // При нажатии
		player.lose = false; //Мы НЕ проиграли
	
		restart.SetActive (false); //Выкл. кнопку рестарта
		restorepl.SetActive (false); // и воскреса
		Coins.count_coins -= player.kolvocoins; //Кол-во монет - цена воскреса
		SpawnRockets.time = 10; //Задержка новых метеоров
		Background.beep1 = 1; //БИИП
		flag_voskres = 1; //Флаг воскрес = 1
			
		Faling.fallspeed = 1; // Замедление метеоров

			

	}

}