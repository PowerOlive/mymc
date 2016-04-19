using UnityEngine;
using System.Collections;
public class CubeCreate : MonoBehaviour {

	public GameObject cubePrefab;
	// Use this for initialization
	void Start () {
		Vector3 pos = transform.position;
		int max = 100;
		int maxHeight = 100;
		for (int i = 0; i < max; i++) {
			for (int j = 0; j < max; j++) {
				Vector3 createPos = new Vector3 (pos.x-max/2+i,Mathf.RoundToInt(Mathf.PerlinNoise (i/(float)max, j/(float)max)*maxHeight),pos.z-max/2+j);
				Instantiate (cubePrefab, createPos, transform.rotation);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
