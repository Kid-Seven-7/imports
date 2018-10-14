using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class statsScript : MonoBehaviour {

	public GameObject canvas;

	public Button button;

	public Slider slider;

	float time = 0;

	bool visible = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		// Debug.Log(slider.value);

		if (Input.GetKey(KeyCode.C)){
			Debug.Log("c clicked");
			canvas.SetActive(false);
		}
	}
}
