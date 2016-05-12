using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Play : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void play(){
		Time.timeScale = 1f;
		SceneManager.LoadScene("Level");
	}

}
