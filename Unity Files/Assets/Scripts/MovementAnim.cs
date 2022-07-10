using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MovementAnim : MonoBehaviour
{
	private char north = 'N';
	private char south = 'S';
	private char west = 'W';
	private char east = 'E';        
	private char curDirection;    // The direction that the robot is facing
    private Animator anime;
    private Rigidbody rbody;


    void Start() {
		rbody = this.GetComponent<Rigidbody> ();
		anime = this.GetComponent<Animator>();

        // The starting direction of the robot on the first 2 levels is north, so: 
		curDirection = north;

        // But on the third level it's west:
	    if (SceneManager.GetActiveScene().name == "Level 3")
			curDirection = west;	
	}


    void Update()	{
        
        // The movement of the robot happens here
        // A short description of the algorithm is this:
        // If the robot is not moving
        //   If the user presses any of the arrow keys
        //     based on the curDirection, first rotate the robot
        //     and then move it towards the corresponding input of the user.
        //     Also, set the new curDirection so that it matches the arrow pressed.
        //     Finally, increase the counter of the total moves.
		if (anime.GetFloat("Vertical") == 0.0f) { 
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				if (curDirection != north)	{
					if (curDirection == west)	{
						transform.Rotate(0, 90, 0);
					}
					else if (curDirection == east)
						transform.Rotate(0, -90, 0);
					else 
						transform.Rotate(0, 180, 0);
				}
                anime.SetFloat("Vertical", 1.0f);
                curDirection = north;
                MovesCounter.movesValue++;
            } 
			else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				if (curDirection != west)	{
					if (curDirection == north)
						transform.Rotate(0, -90, 0);
					else if (curDirection == east)
						transform.Rotate(0, 180, 0);
					else 
						transform.Rotate(0, 90, 0);
				}
				anime.SetFloat ("Vertical", 1.0f);
                curDirection = west;
                MovesCounter.movesValue++;
			}
			else if (Input.GetKeyDown (KeyCode.RightArrow)) {
				if (curDirection != east)	{
					if (curDirection == north)
						transform.Rotate(0, 90, 0);
					else if (curDirection == west)
						transform.Rotate(0, 180, 0);
					else 
						transform.Rotate(0, -90, 0);
				}
				anime.SetFloat ("Vertical", 1.0f);
                curDirection = east;
                MovesCounter.movesValue++;
			} 
			else if (Input.GetKeyDown (KeyCode.DownArrow)) {
				if (curDirection != south)	{
					if (curDirection == north)
						transform.Rotate(0, 180, 0);
					else if (curDirection == east)
						transform.Rotate(0, 90, 0);
					else 
						transform.Rotate(0, -90, 0);
				}
				anime.SetFloat ("Vertical", 1.0f);
                curDirection = south;
                MovesCounter.movesValue++;
			}
        }
    }


	void OnTriggerEnter(Collider collision)		{
		anime.SetFloat ("Vertical", 0.0f);
        // A lot of things happen in the next command.
        // What we are trying to do is, after the collision, to teleport the player back
        //   towards the center of the cube he is standing on, as close as we can.
        // First we try to round his current x and z coordinates to the closest integer
        //   We do that with the help of the Mathf.RoundToInt method.
        // Then, we cast it to float again.
        // If we were able to use the Vector3Int method to create the teleport
        //   position we would successfully transfer the robot to the center 
        //   of the cube it's standing. We can't use this method though because
        //   the y coordinate of the robot's position is a constant and is 0.5.
        // Finally, let's note here that maybe(!) an improvement to the next 
        //   line would be to use the rigidbody and not the transform property
        //   of the object, but so far, it's working fine as it is.
        transform.position = new Vector3((float)Mathf.RoundToInt(transform.position.x), transform.position.y, (float)Mathf.RoundToInt(transform.position.z));
	}
		
}



