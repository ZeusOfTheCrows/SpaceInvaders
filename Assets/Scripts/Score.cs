using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour {

    int score;

    public Text inputText;

    public Font inputFont;

    public EndScreen endScreenScript;

	// Use this for initialization
	void Start () {

        inputText.font = inputFont;
        
        /*Component TextAsComponent = gameObject.GetComponent("Text");
        inputText = (Text)TextAsComponent;

        inputText = gameObject.GetComponent<Text>();*/
    }

    /*public T MyGetComponent<T>() where T : Component
    {
        T inputText;
        Component textAsComponent = gameObject.GetComponent("Text");
        inputText = (T) textAsComponent;
        return inputText;
    }*/

    // Update is called once per frame
    void Update()
    {

        GameObject[] amountOfEnemies = GameObject.FindGameObjectsWithTag("Enemies");

        score = 55 - amountOfEnemies.Length;

        //Debug.Log(score);

        inputText.text = score.ToString("0000"); // force four zeroes? {0:00}

        if (amountOfEnemies.Length == 0)
        {
            endScreenScript.EndGame();
        }
    }
}