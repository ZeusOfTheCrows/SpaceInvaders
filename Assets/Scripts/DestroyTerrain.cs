using UnityEngine;
using System.Collections;

public class DestroyTerrain : MonoBehaviour {


    int numberOfTimesHit = 0;

    // Use this for initialization
    void Start () {
        //Use 6 sprites as terrain destroy
        

    }
	
    public void TerrainIsHit() //not being triggered?
    {
        numberOfTimesHit++;

        if (numberOfTimesHit == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material.mainTexture = Resources.Load<Texture>("Terrain1(D1)");
        }

        else if (numberOfTimesHit == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material.mainTexture = Resources.Load<Texture>("Terrain1(D2)");
        }

        else if (numberOfTimesHit == 3)
        {
            Destroy(gameObject);
        }

    }

	// Update is called once per frame
	void Update () {

        //Debug.Log("hello" + numberOfTimesHit);
    }
}
//six different textures - destroy gameobject remove mesh rendererw