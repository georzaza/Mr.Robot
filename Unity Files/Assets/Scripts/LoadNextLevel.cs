using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
	public int nextSceneLoad;


	void Start()	{
		nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
	}

	public void NextLevel() {
		SceneManager.LoadScene(nextSceneLoad);
		MovesCounter.movesValue = 0;
	}
}
