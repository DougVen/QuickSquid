using UnityEngine;
using System.Collections;

public class BeginPlanet : MonoBehaviour {
    public bool one = true;
    private GameObject squidplayer;
    public GameObject select;
    public GameObject gen;
    public GameObject score;


    // Use this for initialization
    void Start () {
	
	}
    public void OnMouseDown()
    {
            
        if (one)
        {
            GameObject.Instantiate(gen);
            select.GetComponent<PlanetGrav>().enabled = true;
            score.GetComponent<Score>().add = 1;
            one = false;

        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
