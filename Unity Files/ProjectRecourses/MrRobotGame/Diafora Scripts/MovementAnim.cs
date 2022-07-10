using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MovementAnim : MonoBehaviour
{
	public Animator anime;
	private Rigidbody rbody;
	Vector3 variable;


	void Start() {
		rbody = this.GetComponent<Rigidbody> ();
		anime = this.GetComponent<Animator>();
	}


    // Update is called once per frame
    void Update()	{


		// I dont know if you need to edit this in just ONE BIG for loop
		// but i think you should take a look at it.
		if (Input.GetKeyDown (KeyCode.UpArrow)){
			anime.SetFloat ("Vertical", 1.0f);
			MovesCounter.movesValue++;
		}
		
		if (anime.GetFloat("Vertical") == 0.0f) {
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				transform.Rotate (0, 90, 0);
			} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				transform.Rotate (0, -90, 0);
			} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
				transform.Rotate (0, 180, 0);
			}
		} 

	}


	void OnTriggerEnter(Collider collision)		{
		anime.SetFloat ("Vertical", 0.0f);
		// A LOT of things happen in the next command.
		// What we are trying to do is, after the collision, to teleport the player back
		//   to the center of the cube he is standing on, as close as we can.
		// First we try to round his current transform.position.x and transform.position.z to the closest integer
		//   with the help of the Mathf.RoundToInt method.
		// Then, and because Vector3 needs float parameters, we convert it to float.
		// Note that in this case we can't use the Vector3Int to create the teleport position
		//   as the transform.position.y value must be a constant, and it's not an integer. 
		// Finally
		// many articles report that it's better to teleport an Object using it's rigidbody
		// and not it's transform property.
		// This is to be tested, as my project-related-time was near it's end by the time i was writing this line.
		transform.position = new Vector3((float)Mathf.RoundToInt(transform.position.x), transform.position.y, (float)Mathf.RoundToInt(transform.position.z));
	}
}



/**
			These Changes Were Applied On Prefabs.

 fixed the box collider of the object outsideHorizontalWall 2(5)

 removed the colliders of the Grid cubes.
 Regarding the above change:
 1)  the colliders of the finish-level cubes were lost, so i added new ones. 
 2)  i did the step 1 ONLY for the first 2 levels. Level 3 completion is checked by the new script. Keep reading.

________________________________________________________________________________________
							Kyle: 
	
Rigidbody: 
	
	is Kinematic 
		Ticked
	Interpolation
		Extrapolate :  This property "predicts" where the rigidbody will 
		be in the next frame, so its best to use it to stop Kyle earlier.
	Collision Detection
		Continuous Speculative: The best option suggested by Unity
		for moving objects.


Box Collider:
		IsTrigger
			must be enabled if we want to trigger any collisions, so Ticked.

		Changed the Y scale of the collider, so it barely touches the ground.


Animator --> Walk fwd State --> Foot IK --> Ticked.


________________________________________________________________________________________
						All Walls:
	Colliders:	
		IsTrigger
			must be enabled if we want to trigger any collisions, so Ticked.


________________________________________________________________________________________

		added the CheckGameEnd script and attached it on the proper cube.

		Fixed the lightning Intensity on the ThirdLevel.
		Its value must be around 2 for better display.

________________________________________________________________________________________

oh, and i dont remember the rotation of Kyle in the third level (i moved him to be able to test faster 
 the CheckGameEnd script)
So, his new rotation is 0, 0, 0 .





I think that's all, although i am sure i forget things.


 */
