using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maximumGuess;
    int minimumGuess;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }


    void StartGame()
    {
        maximumGuess = 1000;
        minimumGuess = 1;
        guess = 500;
        Debug.Log("YOOHOO! WELCOME TO NUMBER GUESSING GAME!");
        Debug.Log("Pick a number.");
        Debug.Log("Higher number is: " + maximumGuess);
        Debug.Log("Lower number is: " + minimumGuess);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        maximumGuess = maximumGuess + 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minimumGuess = guess;
            NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           maximumGuess = guess;
           NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("This is it!");
            StartGame(); 
        }
    }

    void NextGuess()
    {
        guess = (maximumGuess + minimumGuess) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }
}
