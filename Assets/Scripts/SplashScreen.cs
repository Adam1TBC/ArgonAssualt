using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

    [SerializeField] float delay = 3f;

	// Use this for initialization
	void Start () {
        Invoke("LoadFirstScene", delay);
	}
	
	void LoadFirstScene() {
        SceneManager.LoadScene(0);
    }
}
