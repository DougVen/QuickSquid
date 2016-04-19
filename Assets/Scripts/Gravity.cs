using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {
    public float speed, add,
        time;
    private GameObject squidplayer;
    // Use this for initialization

    void Start () {
       squidplayer = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("Faster", time, time);
    }

    void Faster()
    {
        if(speed<=10)
        speed += add;

        if(squidplayer.GetComponent<Squid>().speed<=25)
        squidplayer.GetComponent<Squid>().speed += add;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down*speed * Time.deltaTime);
    }
}
