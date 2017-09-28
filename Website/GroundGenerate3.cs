using UnityEngine;
using System.Collections;

public class GroundGenerate3 : MonoBehaviour {
	public int width = 5;
	public int height = 1;
	public int x=0;
	public GameObject tilePrefab;
	public GameObject Player;
	// Use this for initialization
	void Start () {
		tilePrefab.transform.position.x = new Vector3 (Player.transform.position.x+x, 0, 0);
		for (int x=0; x<width; x++)
		{
			Instantiate (tilePrefab);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (tilePrefab.transform.position.x < Player.transform.position.x - 5)
		{
			Destroy (tilePrefab);
		}
	}
	
}
