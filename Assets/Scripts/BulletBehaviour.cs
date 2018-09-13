using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour
{
    // ~~ASK MATT ABOUT DOUBLE NEGATIVE.~~ Fixed. Ask Matt about random bullet paths.

    public float bulletMoveSpeed = -2.0f;

    public float bulletMinHeight = 0;

    public float bulletMaxHeight = 203;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider collisionObject)
    {
        if(collisionObject.gameObject.tag == "Terrain")
        {
            DestroyTerrain destroyTerrain = collisionObject.gameObject.GetComponent<DestroyTerrain>();

            destroyTerrain.TerrainIsHit();
        }

        else if(collisionObject.gameObject.tag == "Player")
        {
            DestroyPlayer destroyPlayer = collisionObject.gameObject.GetComponent<DestroyPlayer>();

            destroyPlayer.PlayerIsHit();
        }

        else if (collisionObject.gameObject.tag == "Enemies")
        {
            //DestroyPlayer destroyPlayer = collisionObject.gameObject.GetComponent<DestroyPlayer>();

            //destroyPlayer.PlayerIsHit();
        }

        else
        {
            Destroy(collisionObject.gameObject);
        }
        
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f, bulletMoveSpeed * Time.deltaTime, 0.0f);

        if (transform.position.y < bulletMinHeight || transform.position.y > bulletMaxHeight)
            {
            //destroy bullet
            Destroy(gameObject);
        }
    }
}
