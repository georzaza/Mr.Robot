using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsLevelLoader : MonoBehaviour
{

    public void LevelOne () {
		SceneManager.LoadScene("Level 1");
		MovesCounter.movesValue = 0;
    }

	public void LevelTwo () {
		SceneManager.LoadScene("Level 2");
		MovesCounter.movesValue = 0;
	}

	public void LevelThree () {
		SceneManager.LoadScene("Level 3");
		MovesCounter.movesValue = 0;
	}
}
