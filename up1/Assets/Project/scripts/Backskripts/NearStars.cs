using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearStars : MonoBehaviour {


	void Start () {
		var weight = Camera.main.orthographicSize * 1.5f;
		var height = weight * Screen.height / Screen.height * 1.5f;
		if (gameObject.name == "NearStars") {
			transform.localScale = new Vector3 (weight, height, 0);
		}
	}


}