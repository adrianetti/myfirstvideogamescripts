using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Epilogo : MonoBehaviour
{
	public float delay = 0.1f;
	string fullText = "Parece ser una noche muy normal, pero no lo es, algo diferente pasa. \n\nEmpieza a llover. \n\nSimoney, ¿Qué estás soñando ahora?  \n\n¿Será esto un sueño? ";
	private string currentText = "";

	// Use this for initialization
	void Start()
	{
		StartCoroutine(ShowText());
	}

	IEnumerator ShowText()
	{
		for (int i = 0; i < fullText.Length; i++)
		{
			currentText = fullText.Substring(0, i);
			this.GetComponent<Text>().text = currentText;
			yield return new WaitForSeconds(delay);
		}
		StopAllCoroutines();
	}
}
