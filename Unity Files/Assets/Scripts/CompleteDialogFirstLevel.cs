using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompleteDialogFirstLevel : MonoBehaviour
{
	public GameObject LevelDialog;
	public Text totalMoves;
	public GameObject[] star;

	public void OnTriggerEnter(Collider collision) {
		
		if (collision.CompareTag("Player")) {
			LevelDialog.SetActive(true);
			totalMoves.text = "Total Moves: " + MovesCounter.movesValue;

			// The solution with the least possible moves for
			//   the 1st level is 4 so lets show the player 
			//   how he performed based on a 3-star award system.
			if (MovesCounter.movesValue < 5) {
				star[0].SetActive(true);
				star[1].SetActive(true);
				star[2].SetActive(true);
			} else if (MovesCounter.movesValue < 8) {
				star[0].SetActive(true);
				star[1].SetActive(true);
			} else {
				star[0].SetActive(true);
			}
		
			// By being inside this function we know that the player
			//   successfully completed level 1. Setting this value
			//   to 1, unlocks the 1st and 2nd levels only in the 
			//   Select Level menu.
			LevelSelection.lockLevels = 1;
		}

	}
}
