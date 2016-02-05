using UnityEngine;
using System.Collections;

public class ChangeTexts : MonoBehaviour {

	public string[] texts;
	public float speed;

	private TextMesh textObject;

	// Show letter by letter
	private string changingTextTo = "";
	private int currentTextIndex = -1;
	private float currentTime = 0;

	// Use this for initialization
	void Start () {
		textObject = GetComponent<TextMesh>();

	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Return)) {
			ChangeText ();
		}
	}

	void Update () {
//		SlowlyChangeText ();
	}

	string GetNextText () {
		currentTextIndex ++;
		return texts[currentTextIndex % texts.Length];
	}

	void ChangeText () {
		textObject.text = GetNextText ();
	}
//
//	void SlowlyChangeText () {
//		if (changingTextTo == "")
//			return;
//
//
//	}
}
