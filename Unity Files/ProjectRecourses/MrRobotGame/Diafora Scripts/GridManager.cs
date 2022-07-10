using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {
	
	private int rows = 5;
	private int cols = 8;
	private float tileSize = 1;
	
	void Start() {
		GenerateGrid();
	}
	
	private void GenerateGrid() {
		for( int row = 0; row < rows; row++ ) {
			for( int col = 0; col < cols; col++) {
				
				GameObject tile = (GameObject)Instantiate( referenceTile, tranform);
				
				float posX = col * tileSize;
				float posY = row * -tileSize;
				
				tile.transform.position = new Vector2( posX, posY);
			}
		}
		
		Destroy(referenceTile);
	}
	
	void Update () {
		
	}
	
	
}