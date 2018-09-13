using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SetTimeToZero : MonoBehaviour {

    float previousTimeScale;

    public string whatToLoad;

    float timer = 0;

    bool gameHasEnded;

    // Use this for initialization
	void Start () {
        StartCoroutine(SettingTimeToZero());

        previousTimeScale = Time.timeScale;
    }

    IEnumerator SettingTimeToZero()
    {
        yield return new WaitForSeconds(0.7f);
        Time.timeScale = 0;
        gameHasEnded = true;
    }

    void Update()
    {
        /*if (!gameHasEnded)
        {
            return;
        }*/


        if (gameHasEnded)
        {
            timer += Time.unscaledDeltaTime;
            //Debug.Log(timer);
               if (timer > 3)
               {
                   Time.timeScale = previousTimeScale + 0.5f;
                   SceneManager.LoadScene(whatToLoad);
               }
        }
        
       
    }

	// Update is called once per frame
	


}
