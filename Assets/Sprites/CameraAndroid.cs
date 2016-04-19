using UnityEngine;
using System.Collections;

public class CameraAndroid : MonoBehaviour {
    public int scale;
   
    void Start () {
        Camera.main.orthographicSize = Mathf.Max(Screen.width, Screen.height)/scale;
      
        
    }
  

}
