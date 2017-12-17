using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase2 : MonoBehaviour {

    public void Main2()
    {
        GetComponent<MainScript>().current_health = 10f;
        GetComponent<MainScript>().max_health = 15f;
        GetComponent<MainScript>().cleaniness = 10f;
        GetComponent<MainScript>().max_hunger = 10f;
        GetComponent<MainScript>().exp = 0f;
        GetComponent<MainScript>().exp_to_reach_next_level = 25f;
    }
}
