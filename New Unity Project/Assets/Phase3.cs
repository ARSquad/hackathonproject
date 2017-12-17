using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase3 : MonoBehaviour {

	 public void Main3()
    {
        GetComponent<MainScript>().current_health = 10f;
        GetComponent<MainScript>().max_health = 10f;
        GetComponent<MainScript>().cleaniness = 10f;
        GetComponent<MainScript>().max_hunger = 15f;
        GetComponent<MainScript>().exp = 0f;
        GetComponent<MainScript>().exp_to_reach_next_level = 30f;
    }
}
