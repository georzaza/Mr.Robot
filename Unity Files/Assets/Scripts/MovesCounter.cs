using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovesCounter : MonoBehaviour
{
    // a counter of the moves that the player has done so far.
    // This variable is being accessed or changed in the following files:
	//   MovementAnim.cs, ButtonsLevelLoader.cs, ButtonsMenuLoader.cs
	//   CompleteDialogFirstLevel.cs, CompleteDialogSecondLevel.cs
	//   CompleteDialogLastLevel.cs
    // We understand that the game's code should be re-configured so as to
	//   fullfill this variable's purpose in another way, as the declaration
	//   public makes the game's stars system prone to hacking/cracking.
	public static int movesValue = 0;

    public Text moves;

    void Start()	{
		moves = GetComponent<Text>();
    }

    void Update()	{
		moves.text = "Moves: " + movesValue;
    }
}
