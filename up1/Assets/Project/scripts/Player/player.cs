using UnityEngine;

public class player : MonoBehaviour {

	public GameObject restart; //Объявление  объекта кнопки рестарт
	public GameObject restorepl; //Кнопочка для воскрешения
	public static int kolvocoins = 5; //Колличество монеток для открытия воскрешения
	private float time = 2; //Таймер для безопасного времени
	private float timebaza = 2; //база
	private AudioSource coinsbeep; //Подбор монеты

	public static bool lose = false;    // Проигрыш


	void Start(){
		coinsbeep = GetComponent<AudioSource> ();//Активация звука
	}
	void Update (){
		if (Restore_player.flag_voskres == 1) { //Если ты только что воскрес + время
			//SpawnRockets.time = 10;

			time -= Time.deltaTime; //Таймер
			if (time <= 0) {
				time = timebaza;

				Faling.fallspeed = Faling.fallspeadbaza; //Вернуть скорость падения к исходной
				Restore_player.flag_voskres = 0; //Флаг ВОСКРЕС = False
			}
		}
	}


	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "bomb") { //Если столкнулись с метеором
			lose = true; //Проиграл
			restart.SetActive (true); // Кнопка рестарта активна

			if (Coins.count_coins >= kolvocoins) { //Если кол-во монет больше нужного для воскреса
				restorepl.SetActive (true); //Кнопка воскрешения активна

			}
		}

		if (other.gameObject.tag == "Coin") { //Если столкнулся с монетой
			coinsbeep.Play (); //БИИИИП
			Coins.count_coins++; //Кол-во монет +
			CoinsFalling.flag_podbor = 0; //Флаг забора монеты = 0
		
	
				}
	}
	}
