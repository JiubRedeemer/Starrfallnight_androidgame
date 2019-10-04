using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown () {
		player.lose = false;
		SceneManager.LoadScene ("main");
		SpawnRockets.score_player = 0;
	}

}
