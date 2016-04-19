using UnityEngine;
using System.Collections;

public class LineGRav : MonoBehaviour {
    public float speed;
    public string color;
    private GameObject squid;
    // Use this for initialization
    void Start () {
        squid = GameObject.FindGameObjectWithTag("Player");
        GetComponent<Transform>().Rotate(0, 0, -90);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down* speed * Time.deltaTime);     
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "GameController")
        {
            squid.GetComponent<Squid>().color = color;
            Object.Destroy(gameObject);

        }
    }
}
