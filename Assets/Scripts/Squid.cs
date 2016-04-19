using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Squid : MonoBehaviour {

    // Use this for initialization
    public string color="blue";
    public Vector3 targetVector,assistantVector;
    public float hp = 3;
    public float verticalSpeedLimit = 5f,
        speed = 5f,
                    horizontalSpeed = 5f;
    public Sprite blue, green, orange, pink, purple;
    public Canvas over;

    public bool move = false, moving = false, finished = true;
    void Start () {
        over.enabled = false;
        GetComponent<SpriteRenderer>().sprite = blue;
    }
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Transform>().position.x <= -10)
        {
            over.enabled = true;
            Time.timeScale = 0.0f;
            Object.Destroy(gameObject);
        }
        if (!moving && move)
        {
            targetVector = assistantVector;
            moving = true;
        }
        if (move)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetVector , speed * Time.deltaTime);
           

        }
      

        switch (color)
        {
            case "blue":
                GetComponent<SpriteRenderer>().sprite = blue;
                break;
            case "green":
                GetComponent<SpriteRenderer>().sprite = green;
                break;
            case "purple":
                GetComponent<SpriteRenderer>().sprite = purple;
                break;
            case "pink":
                GetComponent<SpriteRenderer>().sprite = pink;
                break;
            case "orange":
                GetComponent<SpriteRenderer>().sprite = orange;
                break;
        }
	}
}
