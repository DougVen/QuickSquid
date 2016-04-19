using UnityEngine;
using System.Collections;

public class Dots : MonoBehaviour
{

    // Use this for initialization
    public string color;
    private int x, y;
    public float hp = 3;
    public float speed= 5f;
    private GameObject squidplayer;
    public bool clicked = false,restart=false;
    static bool exist = true;
    public static bool begin = false;
    
    private Squid squid;
    // Use this for initialization
    void Start()
    {
        squidplayer = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {

        if (GetComponent<Transform>().position.x <= -10)
        {
            Object.Destroy(gameObject);
        }

        gravity();
        
    }

 
    public void gravity() 
    {
        
        if (clicked)
        {
            exist = false;
            GetComponent<PlanetGrav>().enabled=false;
            squidplayer.GetComponent<Gravity>().enabled = false;
            if (squidplayer.transform.position == transform.position)
                {
                Object.Destroy(gameObject);
                squidplayer.GetComponent<Squid>().move = false;
                    squidplayer.GetComponent<Squid>().moving = false;
                squidplayer.GetComponent<Gravity>().enabled = true;
                exist = true;

                }
            
        
        }
             

       
    }
     public void OnMouseDown() {
      
        if (exist&& color == squidplayer.GetComponent<Squid>().color)
        {
            clicked = true;
            if (color == squidplayer.GetComponent<Squid>().color)
            {
                print("hey");

                squidplayer.GetComponent<Squid>().assistantVector = transform.position;
                squidplayer.GetComponent<Squid>().move = true;
            }
        }
    }

}
