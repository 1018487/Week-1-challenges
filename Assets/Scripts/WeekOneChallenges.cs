using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekOneChallenges : MonoBehaviour
{
    public string myName; // a string holds only words
    public int myAge; // holds only whole numbers
    public float myHeight; // holds floating point for decimal numbers
    public double myFavouriteNumber; // holds double a float
    public bool isWearingAWatch; // holds only true or false
    public char myFavouriteLetter; // it holds a single character

    // Start is called before the first frame update
    void Start()
    {
        myName = "Orpheus";
        myAge = 100;
        myHeight = 5.23f;
        myFavouriteNumber = 2.44;
        isWearingAWatch = false;
        myFavouriteLetter = ',';

        Debug.Log("Hi my name is " + myName + ", my age in years is " + myAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
