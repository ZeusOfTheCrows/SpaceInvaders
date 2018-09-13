using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    public GameObject EnemyTemplate;
    public int Columns;
    public int Rows;
    public float XMultiplier;
    public float YMultiplier;

	// Use this for initialization
	void Start () {

        for (int y = 0; y < Rows; y++)
        {
            for (int x = 0; x < Columns; x++)
            {
                GameObject Enemy = Instantiate(EnemyTemplate, transform);
                Enemy.transform.localPosition = new Vector3(x, y); 

                //Debug.Log((XMultiplier * x - 0.55f) + "," + (YMultiplier * y));
            }
        }

        Destroy(EnemyTemplate);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
