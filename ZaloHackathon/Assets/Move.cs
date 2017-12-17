using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {
    public Transform startMarker;
    public Pose endMarker;
    private float speed = 0.05F;
    private float startTime;
    private float journeyLength;
    public GameObject camPlr;
    private Animator objani;
    public float current_health, max_health, max_hunger;
    public float cleaniness, hunger, strength = 0;
    public float exp = 0f, exp_to_reach_next_level;
    public GameObject xp, c, h, HP, AGE, Gym_button, Event, Strenght, scene, lvl1, lvl2, lvl3, lvl4;
    Text health_bar, cleaniness_bar, hunger_bar, xp_bar, age_bar, _event, strength_bar;
    int age = 0;
    int x = 0;
    public int score;

    void Start()
    {
        journeyLength = 0;
        objani = GetComponent<Animator>();
        InvokeRepeating("GettingHungry", 2f, 3f);
        InvokeRepeating("GettingDirty", 2f, 3f);
        InvokeRepeating("GettingOld", 2f, 5f);
        InvokeRepeating("HealthRegen", 2f, 8f);
        health_bar = HP.GetComponent<Text>();
        cleaniness_bar = c.GetComponent<Text>();
        hunger_bar = h.GetComponent<Text>();
        xp_bar = xp.GetComponent<Text>();
        age_bar = AGE.GetComponent<Text>();
        _event = Event.GetComponent<Text>();
        strength_bar = Strenght.GetComponent<Text>();
    }
    void Update()
    {
        if (journeyLength > 0)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);

            if (fracJourney < 0.1)
            {
                var lookPos = endMarker.position - transform.position;
                lookPos.y = 0;
                var rotate = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotate, Time.deltaTime * 5f);
            }
        }
        if (Vector3.Distance(startMarker.position, endMarker.position)<0.1)
        {
            objani.SetBool("Start To Move", false);
        }
        if (exp >= exp_to_reach_next_level) exp = exp_to_reach_next_level;
        if (age == 0) { GetComponent<Phase1>().Main1(); lvl1.SetActive(true); }
        if (age == 10 && exp == exp_to_reach_next_level) { GetComponent<Phase2>().Main2(); Gym_button.SetActive(true); lvl1.SetActive(false); lvl2.SetActive(true); }
        if (age == 20 && exp == exp_to_reach_next_level) { GetComponent<Phase3>().Main3(); lvl2.SetActive(false); lvl3.SetActive(true); }
        if (age == 40 && exp == exp_to_reach_next_level) { GetComponent<Phase4>().Main4(); lvl3.SetActive(false); lvl4.SetActive(true); }
        health_bar.text = "Health" + current_health.ToString() + "/" + max_health.ToString();
        cleaniness_bar.text = "Cleanliness:" + cleaniness.ToString() + "/ 10";
        hunger_bar.text = "Hunger: " + hunger.ToString() + "/" + max_hunger.ToString();
        xp_bar.text = "EXP: " + exp.ToString() + "/" + exp_to_reach_next_level.ToString();
        age_bar.text = "Age " + age.ToString();
        strength_bar.text = "Strength: " + strength.ToString();
        if (current_health >= max_health) current_health = max_health;

    }
    public void StartMove (Pose endPos)
    {
        objani.SetBool("Start To Move", true);
        startMarker = this.transform;
        endMarker = endPos;
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
}
