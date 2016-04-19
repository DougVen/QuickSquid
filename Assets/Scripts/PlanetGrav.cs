using UnityEngine;
using System.Collections;

public class PlanetGrav : MonoBehaviour {
    public float speed = 5,time=5;
    static int add = 1;
    // Use this for initialization
    void Start () {
     //  InvokeRepeating("Faster", time, time);
    }
    void Faster()
    {
        if(speed<=12)
        speed+=add;
    }
    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
