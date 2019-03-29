using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    public static int scoreValue = 3; //score
    private int score; //score
    public AudioSource mAudioSrc2;
    void Start()
    {
        mAudioSrc2 = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Objective"))
        {
            mAudioSrc2.Play();
            Destroy(other.gameObject);
            ScoreScript.scoreValue -= 1;
            
        }
    }
}
