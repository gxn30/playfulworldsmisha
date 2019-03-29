using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    //public GameObject endScreen;
    public static int scoreValue = 3;
    //public GameObject EndScreen;
        
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + scoreValue; 
        if (scoreValue <= 0)
        {
            //EndScreen.SetActive(true);
            //endScreen.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("You Won!");
        }
    }
}
