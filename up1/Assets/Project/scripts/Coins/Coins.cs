using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour {
	public GameObject coin; //Объявление объекта монетка
	public  Text Coinstxt; //Текст кол-во монет
	public  Text cFh; //Сколько нужно монет для одного воскрешения (Coins For Heart)

	public Text NeedCountCoins; //Нужно монет для сердца (в меню)
	private float time = 11; // Таймер (Для спавна монет)
	private float timebaza = 11; //Таймер база

	public static int count_coins; //Кол-во монет

	// Use this for initialization
	void Start () {
		cFh.text = "" + player.kolvocoins; //Вывод нужного кол-ва монет в подсказке
			count_coins = 0; //Обнуление
		NeedCountCoins.text = "" + player.kolvocoins; //Вывод нужного кол-ва
	}
	
	// Update is called once per frame
	void Update () {

		Coinstxt.text =   "" + count_coins ; //Вывод кол-ва монет

		time -= Time.deltaTime; //Таймер
		if (time <= 0) {
			time = timebaza;
			SpawnCoin (); //Спавн монетки
	}


	
	

	
	}
	void SpawnCoin () { //Спавн монетки
		if (!player.lose) {
			Instantiate (coin, new Vector3 (Random.Range (-1.5f, 1.5f), 5.5f, -1), Quaternion.identity);

		
}


	}
}