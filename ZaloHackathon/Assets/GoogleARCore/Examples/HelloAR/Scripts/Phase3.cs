﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase3 : MonoBehaviour {

	 public void Main3()
    {
        GetComponent<Move>().current_health = 10f;
        GetComponent<Move>().max_health = 10f;
        GetComponent<Move>().cleaniness = 10f;
        GetComponent<Move>().max_hunger = 15f;
        GetComponent<Move>().exp = 0f;
        GetComponent<Move>().exp_to_reach_next_level = 30f;
    }
}
