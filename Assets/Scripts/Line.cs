using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour {
    public string color;
    private GameObject squidplayer;
    // Use this for initialization
    void Start () {
        squidplayer = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
   //     print(squid.GetComponent<Transform>().position.x);
        if (squidplayer.transform.position == transform.position)
        {
            print("blue");
            squidplayer.GetComponent<Squid>().color = "blue";
        }
        if (GetComponent<Transform>().position.x <= -10)
        {
            Object.Destroy(gameObject);
        }
    }
}
