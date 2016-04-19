using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    private GameObject dot;
	// Use this for initialization
	void Start () {
       
       
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
   public  void Retry()
    {
        Time.timeScale = 1f;
        print("go");
        SceneManager.UnloadScene(1);
        SceneManager.LoadScene("Level");
    }
}
