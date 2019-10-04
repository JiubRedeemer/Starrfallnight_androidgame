using UnityEngine;


public class Faling : MonoBehaviour {
	[SerializeField]
	public static float fallspeed = 3f;
	public static float fallspeadbaza = 0f;
	private float time = 10f;
	private float timebaza= 10f;


	void Start(){
		
	}

	void Update () {
		if (fallspeadbaza < fallspeed) {
			fallspeadbaza = fallspeed;
		
		}
	
			
			time -= Time.deltaTime;
			if (time <= 0) {
				time = timebaza;
			}

		
		if (transform.position.y < -6f) {
			Destroy (gameObject);
			SpawnRockets.score_player ++;
		
		}

		if (player.lose) { //Взял = уничтожить
			Destroy (gameObject);

		}

		if (!player.lose) {transform.position -= new Vector3 (0, fallspeed * Time.deltaTime, 0);
		}
	}
}
