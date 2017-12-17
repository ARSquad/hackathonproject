using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase2 : MonoBehaviour {

    public void Main2()
    {
        GetComponent<Move>().current_health = 10f;
        GetComponent<Move>().max_health = 15f;
        GetComponent<Move>().cleaniness = 10f;
        GetComponent<Move>().max_hunger = 10f;
        GetComponent<Move>().exp = 0f;
        GetComponent<Move>().exp_to_reach_next_level = 25f;
    }
}
