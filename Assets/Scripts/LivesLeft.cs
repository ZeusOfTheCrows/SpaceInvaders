using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class LivesLeft : MonoBehaviour
{

    //int score;

    public GameObject player;

    public Text inputText;

    public Font inputFont;

    //public EndScreen endScreenScript;

    // Use this for initialization
    void Start()
    {

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

        //GameObject[] amountOfEnemies = GameObject.FindGameObjectsWithTag("Enemies");

        //score = 55 - amountOfEnemies.Length;

        //Debug.Log(score);

        if(player == null)
        {
            return;
        }

        DestroyPlayer destroyPlayerScript = player.GetComponent<DestroyPlayer>();
        
        //int livesLeft = destroyPlayerScript.numberOfLives;

        string numberOfLivesLeft = destroyPlayerScript.numberOfLives.ToString();

        inputText.text = numberOfLivesLeft;

        //if (amountOfEnemies.Length == 0)
        //{
        //    endScreenScript.EndGame();
        //}
    }
}