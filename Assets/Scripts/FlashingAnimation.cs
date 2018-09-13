using UnityEngine;
using System.Collections;

public class FlashingAnimation : MonoBehaviour {

    int deathAnimationIteration;
        
    public void DeathAnimation(Vector3 playerPosition)
    {
        gameObject.SetActive(true);

        gameObject.transform.position = playerPosition;

        StartCoroutine(DeathAnimation());
    }
    
    IEnumerator DeathAnimation()
    {
        
        while (deathAnimationIteration < 3)
        {

            yield return new WaitForSeconds(0.1f);
            gameObject.GetComponent<MeshRenderer>().material.mainTexture = Resources.Load<Texture>("Ship(D1)");

            yield return new WaitForSeconds(0.1f);
            gameObject.GetComponent<MeshRenderer>().material.mainTexture = Resources.Load<Texture>("Ship(D2)");

            deathAnimationIteration++;
        }

        deathAnimationIteration = 0;

        gameObject.SetActive(false);
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
