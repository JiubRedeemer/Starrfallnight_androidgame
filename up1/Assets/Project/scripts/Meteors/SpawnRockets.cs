//Основной скрипт, большая часть магии происходит здесь.

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections;

public class SpawnRockets : MonoBehaviour {

	private float lvl = 3; //Уровень сложности (чем больше, тем быстрее ускорение)

	private AudioSource music;  //Объявление музыки
	public GameObject rocket; //Объявление объекта "Ракета" (На самом деле метеор, но в ранней версии игры врагом были ракеты, а мне лень все менять)
	public Text Scoretxt; //Объявление текста "Счет"
	public Text Best_scoretxt; //Объявление текста "Лучший счет"

	private float flag_music = 0; //Объявление флага музыки (нужен для корректного включения после воскрешения)
	public float oftenrocket = 1; //Нужно для увеличения коэффицента скорости спавнинга
	public float oftenrocketbaza = 1; //Для возврата значения к базе
	public static float time = 10; //Таймер
	private float timebaza= 10; //Таймер база

	[SerializeField]
	private float koef = 1; //Тот самый коэф. для ускорения спавна
	public static int score_player; //Переменная с счетом игрока
	public static int best_score; //Переменная с лучшим счетом


	void Start () {
		Faling.fallspeed = 3f; //Для возврата скорости к исходным значениям после проигрыша
		music = GetComponent<AudioSource> (); // Активация музыки

	}

	void Update () {
		if (player.lose && flag_music == 1) { //Если мы прогирали, музыка СТОП
			music.Stop ();
			flag_music = 0;

		}
		if(!player.lose && flag_music == 0){  //Если воскресли музыка СТАРТ
			music.Play ();
			flag_music = 1;
		}


		best_score = PlayerPrefs.GetInt ("SaveScore"); //Получение лучшего счета из памяти
		PlayerPrefs.Save(); //Сохранение все и вся
		Best_scoretxt.text = " " + best_score; //Вывод лучшего счета

		Scoretxt.text = " " + score_player; //Вывод счета
			time -= Time.deltaTime*koef; //Таймер с коэфом.
			if (time <= 0) { 
				time = timebaza;
			if (Restore_player.flag_voskres == 0){
			SpawningRck (); //Функция спавна
			}


			if (score_player > best_score) { //Улучшение лучшего счета
				PlayerPrefs.SetInt("SaveScore", score_player); //Сохранение лучшего счета в памяти
			}

}



		oftenrocket -= Time.deltaTime; //Таймер
		if (oftenrocket <= 0) {
			koef += (lvl/10f);  //Увеличение коэфа.
			Faling.fallspeed += time/100f;
oftenrocket = oftenrocketbaza;
			}

	
	}
		void SpawningRck () { //Спавн ракет
		if (!player.lose) {
			Instantiate (rocket, new Vector3 (Random.Range (-1.5f, 1.5f), 5.5f, -1), Quaternion.identity);

		}
		}


}


