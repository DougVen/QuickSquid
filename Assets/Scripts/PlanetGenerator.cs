using UnityEngine;
using System.Collections;

public class PlanetGenerator : MonoBehaviour {

    // Use this for initialization
    public GameObject planet1, planet2, planet3, planet4, planet5;
    public float spawnTime,x,y;
    Vector3 planetvector;
	void Start() {
        InvokeRepeating("SpawnPlanet", spawnTime, spawnTime);
    }
    void SpawnPlanet()
    {
        planetvector = new Vector3(Random.Range(12, 15), Random.Range(-x, x), 0);
        int rand= Random.Range(1, 6);
        switch (rand)
        {
            case 1:
                GameObject.Instantiate(planet1, planetvector, Quaternion.identity);
                break;
            case 2:
                GameObject.Instantiate(planet2, planetvector, Quaternion.identity);
                break;
            case 3:
                GameObject.Instantiate(planet3, planetvector, Quaternion.identity);
                break;
            case 4:
			GameObject.Instantiate(planet4, planetvector, Quaternion.identity);
                break;
            case 5:
			GameObject.Instantiate(planet5, planetvector, Quaternion.identity);
                break;
        }
    }

}
