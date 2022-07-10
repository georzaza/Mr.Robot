using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadThirdLevel : MonoBehaviour
{
	public void OnTriggerEnter (Collider collision)
	{
		//System.Threading.Thread.Sleep(5000);
		SceneManager.LoadScene("Level 3");
		MovesCounter.movesValue = 0;
	}
}