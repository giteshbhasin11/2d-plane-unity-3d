using UnityEngine;
using System.Collections;

public class back : MonoBehaviour {
	//Vector2 offset = Vector2.zero;
	public 	float  speed = 0.5f;
	public Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		speed = 0.5f;
	}

	// Update is called once per frame
	void Update () {
		float offset = Time.time * speed;
		rend.material.mainTextureOffset = new Vector2 (offset,0f);
	}
}
