using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{ 

    // Update is called once per frame
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessTest;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    public void OnHigherButtonPressed()
    {
        min = guess;
        guess = FindGuess(min, max);
        guessTest.text = guess.ToString();
    }

    public void OnLowerButtonPressed()
    {
        max = guess;
        guess = FindGuess(min, max);
        guessTest.text = guess.ToString();
    }

    void StartGame()
    {
        guess = 0;
        guess = FindGuess(min, max);
        guessTest.text = guess.ToString();
    }

    int FindGuess(int min, int max)
    {
        guess = Random.Range(min,max + 1);
        return guess;
    }
}
