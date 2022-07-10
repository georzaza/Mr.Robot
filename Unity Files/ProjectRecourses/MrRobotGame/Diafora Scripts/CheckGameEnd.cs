using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameEnd : MonoBehaviour	{


	private Animator anime;

    // Start is called before the first frame update
    void Start()	{
		
    }

    // TODO : stop the scene from playing. Maybe load another scene called End of Demo.  
    void Update()	{
		if (GameObject.Find("Robot Kyle").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))	{
			if (GameObject.Find("Robot Kyle").transform.position.x > 13.5 && GameObject.Find("Robot Kyle").transform.position.x < 14.5)	{
				if (GameObject.Find("Robot Kyle").transform.position.z > -0.5 && GameObject.Find("Robot Kyle").transform.position.z < 0.5)	{
					Debug.Log("Finished!");
				}
			}
		}
    }
}
