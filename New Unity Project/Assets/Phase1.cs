using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]

public class Phase1 : MonoBehaviour {

    public void Main1()
    {   GetComponent<MainScript>().current_health = 10f;
        GetComponent<MainScript>().max_health= 10f;
        GetComponent<MainScript>().cleaniness = 10f;
        GetComponent<MainScript>().hunger = 5f;
        GetComponent<MainScript>().max_hunger = 5f;
        GetComponent<MainScript>().exp = 0f;
        GetComponent<MainScript>().exp_to_reach_next_level = 10f;
    }

}
