using UnityEngine;
using System.Collections;

public class EndScreen : MonoBehaviour {

    public GameObject endScreen;

	// Use this for initialization
	void Start () {
	
	}
	
    public void EndGame ()
    {
        gameObject.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
        //Casting?
        //GameObject[] amountOfEnemies = GameObject.FindGameObjectsWithTag("Enemies");

        //int numberOfEnemies = amountOfEnemies.Length;

        /*if(numberOfEnemies == 0 /*&& endScreen.transform.position.y < 0)
        {
            //Debug.Log("Moving Text"); -- solved  
            //endScreen.transform.Translate(0, 550, 0);
            gameObject.SetActive(true);
        }

        */
    }
}
