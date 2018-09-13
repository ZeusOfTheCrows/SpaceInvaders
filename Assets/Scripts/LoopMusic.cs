using UnityEngine;
using System.Collections;
using System;

public class LoopMusic : MonoBehaviour
{
    //public float enemyMoveTime;

    public AudioClip[] audioClips;

    //Vector3 soundPosition = new Vector3(0, 0, 0);

    void Start()
    {
        
        StartCoroutine(MusicLoop());
    }
    IEnumerator MusicLoop()
    {
        EnemyMove enemyMove = GameObject.FindObjectOfType<EnemyMove>();
        //enemyMoveTime = enemyMove.enemyMoveTime;
        //EnemyMove.enemyMoveTime

        while (true)
        {
           if(enemyMove == null)
            {
               enemyMove = GameObject.FindObjectOfType<EnemyMove>();
            }

            for (int i = 0; i < 4; i++)
            {
                yield return new WaitForSeconds(enemyMove.enemyMoveTime);
                AudioSource audio = GetComponent<AudioSource>();
                //audio.Play();
                //Debug.Log("fastinvader " + i);
                audio.clip = audioClips[i];
                //audio.clip = "fastinvader" + i;
                audio.Play();
                //audio.Pitch;
            }

        }
    }
}