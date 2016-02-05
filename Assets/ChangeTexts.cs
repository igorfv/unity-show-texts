using UnityEngine;
using System.Collections;

public class ChangeTexts : MonoBehaviour {

	public string[] texts;
	private TextMesh textObject;

	// Use this for initialization
	void Start () {
		textObject = GetComponent<TextMesh>();
		ChangeText ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Return)) {
			ChangeText ();
		}
	}

	string GetARandomText () {
		int i = Random.Range(0,(texts.Length - 1));
		return texts[i];
	}

	void ChangeText () {
		textObject.text = GetARandomText ();
	}
}
