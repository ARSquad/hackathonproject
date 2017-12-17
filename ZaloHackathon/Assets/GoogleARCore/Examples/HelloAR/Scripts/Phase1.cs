using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]

public class Phase1 : MonoBehaviour {

    public void Main1()
    {   GetComponent<Move>().current_health = 10f;
        GetComponent<Move>().max_health= 10f;
        GetComponent<Move>().cleaniness = 10f;
        GetComponent<Move>().hunger = 5f;
        GetComponent<Move>().max_hunger = 5f;
        GetComponent<Move>().exp = 0f;
        GetComponent<Move>().exp_to_reach_next_level = 10f;
    }

}
