using UnityEngine;
using System.Collections;

public class NewScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        /*
    	for (int i = 0; i < 100; i++)
        {
            Debug.Log("Test" + i);
        }
        */

        int j = 0;
        while (j < 5)
        {
            Debug.Log("Test" + j++);
            if( j == 3)
            {
                break;
            }
        }
	}


    //Ending bullet time!!!

    /*
            i = i + 1;  // i++  ++i
            i = i - 1;  // i--  --i

            i = i * 2; // i *= 2;
            i = i / 2; // i /= 2;

            i = i % 5; // i-%= 5
            

     */

    // Update is called once per frame
    void Update () {
	
	}
}
