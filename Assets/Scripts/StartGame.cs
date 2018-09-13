using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public void OnButtonPress()
    {
        Debug.Log("Clicking On Start");
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
