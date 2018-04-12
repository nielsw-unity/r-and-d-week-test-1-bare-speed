using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CubeSpawner : MonoBehaviour {
	public GameObject prefab;
	public float yOffs = 0.0f;

	void Start () 
	{
		const int gridSize = 20;
		const float spacing = 0.2f;

		float cubeSizeX = prefab.transform.localScale.x + spacing;
		float cubeSizeY = prefab.transform.localScale.y + spacing;
		float cubeSizeZ = prefab.transform.localScale.z + spacing;
		
		float startOffsX = -(gridSize*cubeSizeX*0.5f);
		float startOffsY = -(gridSize*cubeSizeY*0.5f);
		float startOffsZ = -(gridSize*cubeSizeZ*0.5f);

		float zPos = startOffsZ;
		for (int iZ = 0; iZ < gridSize; ++iZ)
		{
			float yPos = startOffsY;
			for (int iY = 0; iY < gridSize; ++iY)
			{
				float xPos = startOffsX;
				for (int iX = 0; iX < gridSize; ++iX)
				{
					GameObject instance = Instantiate(prefab);
					instance.transform.position = new Vector3(xPos, yPos+yOffs, zPos);
					xPos += cubeSizeX;
				}
				
				yPos += cubeSizeY;
			}
			
			zPos += cubeSizeZ;
		}
	}

	// FIXME: add scaling-animation (and move that to ECS)	
	void Update () {
		
	}
}
