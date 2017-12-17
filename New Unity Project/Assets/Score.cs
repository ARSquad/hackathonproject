using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text finalscore;
    void Start()
    {
        finalscore.text = "Final score: " + PlayerPrefs.GetInt("FinalScore").ToString();
    }
 
}
