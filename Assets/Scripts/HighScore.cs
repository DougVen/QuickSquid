using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
		
		public GameObject sc;
		public int high;
		// Use this for initialization

		void Start()
		{
		
		high = PlayerPrefs.GetInt ("High");
		}

		void Update(){
		int x = sc.GetComponent<Score> ().score;
		if (x >= high)
			high = x;
	}

}