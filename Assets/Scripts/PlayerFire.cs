using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {

    public GameObject bullet;

    public AudioClip firingClip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject[] amountOfBullets = GameObject.FindGameObjectsWithTag("Bullet");
        //float numberOfBullets = amountOfBullets.Length;

        //Debug.Log(Input.GetAxis("Jump"));

        //Debug.Log(numberOfBullets);
        /*if (numberOfBullets < 3)
        {
            Debug.Log("Why?");
        }*/
        //Fire on W/Space
        //Create entity "Bullet" and direct

        bool touchToFire = false;

        for(int i=0; i<Input.touchCount; i++)
        {
            Touch fingerOnScreen = Input.GetTouch(i);
            if(fingerOnScreen.phase == TouchPhase.Began)
            {
                touchToFire = true;
                break;
            }
        }

        //if(Input.touchCount != 0)
        //{
            
        //}

        if (/*numberOfBullets*/amountOfBullets.Length < 1 && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire2") || Input.GetAxis("Fire1") > 0.5 || touchToFire))
        {
            GameObject spawnedBullet = Instantiate(bullet);

            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = firingClip;
            audio.Play();

            spawnedBullet.transform.position = transform.position;

            spawnedBullet.tag = "Bullet";
        }

    }
}
