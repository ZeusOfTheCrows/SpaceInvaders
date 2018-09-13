using UnityEngine;
using System.Collections;

public class BulletMove_deprecated : MonoBehaviour {

    public float bulletMoveSpeed;

    public float bulletMultiplierVar = 60f;

    public float bulletMaxHeight = 203;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0.0f, bulletMoveSpeed * bulletMultiplierVar * Time.deltaTime, 0.0f);
        
        if (transform.position.y > bulletMaxHeight)
        {
            //destroy bullet
            Destroy(gameObject);
        }
        
        /*if (transform.rotation.eulerAngles.z != 0)
        {
            Debug.Log("error");
        }*/
    }
}
