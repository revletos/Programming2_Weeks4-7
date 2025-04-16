using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Importing TextMeshPro namespace for text rendering  

public class ScoreUI : MonoBehaviour
{
    public GameObject gameOverScreen; // reference to game over screen game object
    public TextMeshProUGUI scoreText; // reference to the TextMeshProUGUI component for displaying score
                                      // Just TMP reference is for world space text (i.e. damage numbers)
    int scoreValue = 0;   
    bool playState = true; // Variable to track if the game is in play state
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = scoreValue.ToString(); // To ensure text is displayed as intended in case Inspector overrides it as something else 
        gameOverScreen.SetActive(false); //To ensure hidden at start
    }

    // Update is called once per frame
    void Update()
    {
        if (playState == true && Input.GetMouseButtonDown(0))
        {
            scoreValue++;
            scoreText.text = scoreValue.ToString(); // Update the score text 
                                                    // Convert the score value to a string for screen output

        }

        if (scoreValue >= 10)
        {
            gameOverScreen.SetActive(true); // Activate the game over screen when score reaches 10
            //Time.timeScale = 0; // Pause the games - suggested by VS, not part of tutorial but interesting function
            playState = false; // Set playState to false to stop score incrementing
        }

        if (playState == false && Input.GetMouseButtonDown(1))
        {
            gameOverScreen.SetActive(false); // Deactivate the game over screen when score reaches 10
            playState = true; // Set playState to true to allow score incrementing again
            scoreValue = 0; // Reset the score value to 0
            scoreText.text = scoreValue.ToString(); // Update the score text 

            //This was all suggested by VS, thank you for generally doing what I want you to VS, very cool. 
        }
    }
}
