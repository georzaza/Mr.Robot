using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelSelection : MonoBehaviour
{
	// This variable corresponds to the 1, 2, 3 buttons
	//   in the level selection menu.
	[SerializeField]private Button[] lvlButtons;

	// This variable helps us lock or unlock the levels.
	// When lockLevels is 0, only the 1st level is unlocked
	//   If it's value is 1, then the only locked level is the 3rd.
	// This variable is being accessed or changed in the following files:
	//   ButtonsMenuLoader.cs, 
	//   CompleteDialogFirstLevel.cs, CompleteDialogSecondLevel.cs
	// We understand that the game's code should be re-configured so as to
	//   fullfill this variable's purpose in another way, as the declaration
	//   public makes the lock-levels system prone to hacking/cracking.
	public static int lockLevels = 0;


	// Lock the levels here accorrdingly to the above description of 
	//   the lockLevels variable.
	public void Start()	{
		for (int i = 0; i < lvlButtons.Length; i++)	{
			if (lockLevels < i )
				lvlButtons[i].interactable = false;
		}
	}
}