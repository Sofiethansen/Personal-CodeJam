using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Declares a public class called AddPoints
public class AddPoints : MonoBehaviour
{

    // This public interger keeps track of the player's score
    public int score;
    // Reference to a UI text component to display the score when pressing the items
    public Text scoreText;
 
    // Update is called once per frame
    void Update()
    {
        /*Converts the integer "score" to a string and sets the "scoreText"
         * to this string. This ensures the display score is updated every frame
         */
        scoreText.text = score.ToString();
    }
    // Publicc method
    public void AddScore()
    {

        // Increment the score by 1. Method to called to add points
        score++;
    }
    // public method
    public void SubtractScore()
    {
        /* Checks if the score is greater than 0, to ensure it 
         * does not go below 0
         */
        if(score > 0)
        {

            // Decrement the score by 1, if conditions is true
            score--;
        }
    }
}



