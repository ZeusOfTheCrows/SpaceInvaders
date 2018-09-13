using UnityEngine;
using System.Collections;

public class DestroyPlayer : MonoBehaviour
{
    public GameObject enemyBullet;

    public GameObject penultimateLife;

    public GameObject ultimateLife;

    public int numberOfLives = 3;

    public GameObject gameOverScreen;

    public FlashingAnimation flashingAnimation;

    float playerY;
    
    public AudioClip explosionClip;

    //bool thingy = false;

    //public GameObject enemy;

    public void PlayerIsHit()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = explosionClip;
        audio.Play();

        flashingAnimation.DeathAnimation(gameObject.transform.position);

        gameObject.transform.position = new Vector3(0, int.MaxValue, 0);
        
        if(numberOfLives < 4)
        {
            penultimateLife.SetActive(false);
        }

        if (numberOfLives < 3)
        {
            ultimateLife.SetActive(false);
        }

        numberOfLives--;

        if (numberOfLives > 0)
        {
            StartCoroutine(PlayerIsHit(0.6f));
        }
        else
        {
            gameOverScreen.SetActive(true);
        }
        
    }
    
    public IEnumerator PlayerIsHit(float delay)
    {
        yield return new WaitForSeconds(delay);

        gameObject.transform.position = new Vector3(0, playerY, 0);
        // after a delay
        //gameObject.transform;

        //Debug.Log("Instantiate");
        //if (bullet is playerBullet)
        //playerBullet = bullet;
        //Destroy(gameObject);
        //Destroy(enemyBullet.gameObject);
        //GetComponent<Renderer>(enemyBullet).materials[1].mainTexture = new Texture2D(1, 1);
        /*thingy = true;
           yield return new WaitForSeconds(0.1f);
        thingy = false;/*to be renamed*/
        //Debug.Log("Player destroying");
    }

    // Use this for initialization
    void Start()
    {
        playerY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
