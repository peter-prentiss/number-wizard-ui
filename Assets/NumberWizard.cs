using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;
	public Text text;
	
	int maxGuessesAllowed = 10;
	
	void Start () {
		StartGame ();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
//		guess = 500;
		NextGuess ();
		
		max = max + 1;
	}
	
	void NextGuess () {
//		guess = (max + min) / 2;
		guess = Random.Range(min, max + 1);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0)
		{
			SceneManager.LoadScene("Win");
		}
	}
	
	
	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}
	
	public void GuessLower()
	{
		max = guess;
		NextGuess();
	}
}
