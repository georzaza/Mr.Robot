using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompleteDialogLastLevel : MonoBehaviour
{
	public GameObject LevelDialog;
	public Text totalMoves;
	public GameObject[] star;

	void Update()
	{
		// This if checks whether the game has finished. 
		//   That happens when the robot is standing still on top 
		//   of the cube with coordinates (14, 0.5, 0). 
		//   The 2nd parameter is a constant so it's not checked.
		// For a better understanding of this, refer to the comment 
		//   section of the method onTriggerEnter, of the
		//   MovementAnim.cs script file.
		if ((int)(GameObject.FindWithTag("Player").transform.position.x + 0.5) == 14 && 
			(int)(GameObject.FindWithTag("Player").transform.position.z + 0.5) ==  0 &&
			GameObject.FindWithTag("Player").GetComponent<Animator>().GetFloat("Vertical") == 0.0f) {

			LevelDialog.SetActive(true);
			totalMoves.text = "Total Moves: " + MovesCounter.movesValue;

			// The solution with the least possible moves for
			//   the 3rd level is 15 so lets show the player 
			//   how he performed based on a 3-star award system.
			if (MovesCounter.movesValue < 16) {
				star[0].SetActive(true);
				star[1].SetActive(true);
				star[2].SetActive(true);
			} else if (MovesCounter.movesValue < 20) {
				star[0].SetActive(true);
				star[1].SetActive(true);
			} else {
				star[0].SetActive(true);
			}
		}
	}
}
