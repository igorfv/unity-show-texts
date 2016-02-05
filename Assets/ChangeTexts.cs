using UnityEngine;
using System.Collections;

public class ChangeTexts : MonoBehaviour {

	public string[] texts;
	public float speed;

	private TextMesh textObject;

	// Show letter by letter
	private int currentTextIndex = -1;

	private string changingTextTo = "";
	private int currentLetterIndex = 0;
	private float previousTime;

	// Use this for initialization
	void Start () {
		textObject = GetComponent<TextMesh>();
		previousTime = Time.time;
		ChangeText ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Return)) {
			ChangeText ();
		}
	}

	void Update () {
		SlowlyChangeText ();
	}

	string GetNextText () {
		currentTextIndex ++;
		return texts[currentTextIndex % texts.Length];
	}

	void ChangeText () {
		if (changingTextTo != "")
			return;

		currentLetterIndex = 0;
		changingTextTo = GetNextText ();
	}

	void SlowlyChangeText () {
		if (changingTextTo == "")
			return;

		if (Time.time > previousTime + speed) {
			previousTime = Time.time;

			textObject.text = changingTextTo.Substring (0, currentLetterIndex);

			currentLetterIndex++;

			if (changingTextTo.Length < currentLetterIndex) {
				currentLetterIndex = 0;
				changingTextTo = "";
			}
		}
	}
}
