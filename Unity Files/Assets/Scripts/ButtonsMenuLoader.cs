using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ButtonsMenuLoader : MonoBehaviour
{
	public static bool newGame = true;


	public void NewGame () {
		newGame = true;
		SceneManager.LoadScene("Level 1");
		MovesCounter.movesValue = 0;
		// Setting this to 0 locks all levels except the 
		//   first one in the Select Level menu.
		LevelSelection.lockLevels = 0;
	}

	public void SelectLevel () {
		SceneManager.LoadScene("LevelSelection");
	}

	public void Exit () {
		Application.Quit();
	}
}
