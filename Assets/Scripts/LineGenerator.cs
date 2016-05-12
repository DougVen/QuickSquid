using UnityEngine;
using System.Collections;

public class LineGenerator : MonoBehaviour {
    // Use this for initialization
    public GameObject line1,line2,line3,line4,line5;
    public float spawnTime, x, y;
    Vector3 planetvector;
    void Start()
    {
        InvokeRepeating("SpawnLine", spawnTime, spawnTime);
    }

    void chooseColor()
    {

    }
    void SpawnLine()
    {
        planetvector = new Vector3(10,0, 1);

        int rand = Random.Range(1, 6);
      //  squid.GetComponent<Squid>().color
        switch (rand)
        {
            case 1:
                GameObject.Instantiate(line1, planetvector, Quaternion.identity);
                break;
            case 2:
                GameObject.Instantiate(line2, planetvector, Quaternion.identity);
                break;
            case 3:
                GameObject.Instantiate(line3, planetvector, Quaternion.identity);
                break;
            case 4:
                GameObject.Instantiate(line4, planetvector, Quaternion.identity);
                break;
            case 5:
                GameObject.Instantiate(line5, planetvector, Quaternion.identity);
                break;
        }
    }
}
