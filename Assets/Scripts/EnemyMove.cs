using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{
    public float enemyMoveDistance = 0.07f;

    //make time speed up & terrain destroy 1/6!!!

    public /*static*/ float enemyMoveTime = 0.81f;

    int enemyMoveDirection = 1;

    public int enemySprite = 1;

    //public AudioClip Music;

    Vector3 SoundPosition;

    //int audioPtich = 1;

    public Texture armsUp;

    public Texture armsDown;

    public MeshRenderer enemySpriteMesh;

    //bool isDropping;

    void Start()
    {
        armsUp = Resources.Load<Texture>("Enemy1");
        armsDown = Resources.Load<Texture>("Enemy2");

        enemySpriteMesh = gameObject.GetComponent<MeshRenderer>();

        StartCoroutine(RightLeft());
    }
    IEnumerator RightLeft()
    {
        while (true)
        {
            
            for(int i = 0; i < 10; i++)
            {
                yield return new WaitForSeconds(enemyMoveTime);

                if (enemySprite == 1)
                {
                    enemySpriteMesh.material.mainTexture = armsUp;
                }
                else if (enemySprite == -1)
                {
                    enemySpriteMesh.material.mainTexture = armsDown;
                }

                if (enemySprite == 0)
                {
                    GameObject.Destroy(this.gameObject);
                }
                
                else
                {   
                    transform.Translate(enemyMoveDirection * enemyMoveDistance, 0, 0);
                    enemySprite = enemySprite * -1;
                }

                //AudioSource.PlayClipAtPoint(Music, SoundPosition);
                //AudioSource.Pitch;
            }


            yield return new WaitForSeconds(enemyMoveTime);
            transform.Translate(0, -0.1f, 0);
            //yield return new WaitForSeconds(1.0f * enemyMoveTime);
            enemyMoveTime = enemyMoveTime * 0.9f;
            enemyMoveDirection = enemyMoveDirection * -1;
            enemySprite = enemySprite * -1;

            //isDropping = false;



            //transform.Translate(enemyMoveSpeed * Time.deltaTime, 0.0f, 0.0f)/*WaitForSeconds(enemyMoveTime)*/;

            /*Debug.Log("Left");
            transform.Translate(-enemyMoveSpeed * Time.deltaTime, 0.0f, 0.0f);
            yield return new WaitForSeconds(3.5f);*/
        }
    }

    // Update is called once per frame
    void Update()
    {   /*yield return new WaitForSeconds(enemyMoveTime);
            enemyMoveDirection *= -1;
            isDropping = true;*/

        /*I don't know what to do with this:
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 v3Velocity = rb.velocity;*/

        //if (enemySprite == 1)
        //{
        //    gameObject.GetComponent<MeshRenderer>().material.mainTexture = Resources.Load<Texture>("Enemy1");
        //}
        //else if (enemySprite == -1)
        //{
        //    gameObject.GetComponent<MeshRenderer>().material.mainTexture = Resources.Load<Texture>("Enemy2");
        //}

        // [deprecated] float fireInterval = Random.Range(0.0f, 1.0f);

        // Move enemy left/ight  --  move by speed.Variable
        //if (transform.position.x < enemyBoundary || Input.GetKey(KeyCode.O)) //&&
        /*if (!isDropping)
        {
            transform.Translate(enemyMoveSpeed * Time.deltaTime * enemyMoveDirection, 0.0f, 0.0f);
        }
        /*if (transform.position.x > -enemyBoundary)
        {
            transform.Translate(-enemyMoveSpeed * Time.deltaTime, 0.0f, 0.0f);

        }*/

        // Enemy firing 

    }
}
