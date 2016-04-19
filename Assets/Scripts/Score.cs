using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public float time;
    public int add;
    public int score;
    public Text text;
    // Use this for initialization

    void Start()
    {
        InvokeRepeating("Faster", time, time);
    }

    void Faster()
    {

        score += add;
        text.text = "Score: " + score;
    }

}
