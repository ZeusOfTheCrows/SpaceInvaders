using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

    public GameObject gameOverScreen;

    public GameObject player;

    //public AudioSource;
    //bool thingy = false;

    //public GameObject enemy;

    void OnTriggerEnter(Collider collisionObject)
    {
        if (collisionObject.gameObject.tag == "Terrain" || collisionObject.gameObject.tag == "Player")
        {
            gameOverScreen.SetActive(true);

            //DestroyPlayer destroyPlayer = player.GetComponent<DestroyPlayer>();

            //destroyPlayer.PlayerIsHit();
        }

        GameObject go = new GameObject("Boom sound");
        AudioSource audio1 = go.AddComponent<AudioSource>();

        AudioSource audio2 = GetComponent<AudioSource>();
        audio1.clip = audio2.clip;
        audio1.Play();
        Destroy(collisionObject.gameObject);
        Texture explodedTexture = Resources.Load<Texture>("EnemyExploded");
        EnemyMove enemyMove = GetComponent<EnemyMove>();
        enemyMove.enemySprite = 0;
        gameObject.GetComponent<MeshRenderer>().material.mainTexture = explodedTexture;
        //StartCoroutine(NewSprite());

      

       

        //AudioSource.PlayClipAtPoint;
        //if (bullet is playerBullet)
        //playerBullet = bullet;
        ///GetComponent<Renderer>(bullet).materials[1].mainTexture = new Texture2D(1, 1);
        /*thingy = true;
           yield return new WaitForSeconds(0.1f);
        thingy = false;/*to be renamed*/
        //Debug.Log("Enemy destroying");
    }
     
    void NewSprite()
    {
       
        //yield return new WaitForSeconds(enemyMove.enemyMoveTime - 0.4f);
        //Destroy(gameObject);
        
    }

}
