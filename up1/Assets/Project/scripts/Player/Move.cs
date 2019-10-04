using UnityEngine;


public class Move : MonoBehaviour {

	public Transform gamer; 

	[SerializeField]
		private float speed = 10f; //Ограничение на скорость перемещение игрока

	void OnMouseDrag () {
		if(!player.lose){ //Если НЕ проиграл

			if (SpawnRockets.score_player >= 100) { //Снижение ограничения при хорошей игре
				speed = 15f;
			}
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition); 
		mousePos.x = mousePos.x > 1.5f ? 1.5f : mousePos.x;  //Ограничения влево/вправо
		mousePos.x = mousePos.x < -1.5f ? -1.5f : mousePos.x;

			mousePos.y = mousePos.y > -0.8f ? -0.8f : mousePos.y; //Ограничения вверх/вниз
			mousePos.y = mousePos.y < -3f ? -3f : mousePos.y;

		gamer.position = Vector2.MoveTowards (gamer.position, 
				new Vector2 (mousePos.x, mousePos.y),
	speed * Time.deltaTime); //Перемещение
	}

}
}