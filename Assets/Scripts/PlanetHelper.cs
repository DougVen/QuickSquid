using UnityEngine;
using System.Collections;

public class PlanetHelper : MonoBehaviour {

	// Use this for initialization
	public GameObject planet1, planet2, planet3, planet4, planet5,player;
	public float spawnTime,x,y;
	Vector3 planetvector;
	void Start() {
		InvokeRepeating("SpawnPlanet", spawnTime, spawnTime);
		player= GameObject.FindGameObjectWithTag("Player");
	}
	void SpawnPlanet()
	{
		planetvector = new Vector3(Random.Range(12, 15), Random.Range(-x, x), 0);
		switch (player.GetComponent<Squid>().color)
		{
		case "blue":
			GameObject.Instantiate(planet1, planetvector, Quaternion.identity);
			break;
		case "orange":
			GameObject.Instantiate(planet2, planetvector, Quaternion.identity);
			break;
		case "pink":
			GameObject.Instantiate(planet3, planetvector, Quaternion.identity);
			break;
		case "purple":
			GameObject.Instantiate(planet4, planetvector, Quaternion.identity);
			break;
		case "green":
			GameObject.Instantiate(planet5, planetvector, Quaternion.identity);
			break;
		}
	}

}