using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackStars_loop : MonoBehaviour {
	public float speedback = 0.05f;
	private Vector2 offset = Vector2.zero;
	private Material material;
	void Start () {
		material = GetComponent<Renderer> ().material;
		offset = material.GetTextureOffset ("_MainTex");
	}

	void Update () {
		offset.y += speedback * Time.deltaTime / 10f;
		material.SetTextureOffset("_MainTex", offset);
	}
}
