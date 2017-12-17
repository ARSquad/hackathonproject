using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManage : MonoBehaviour {

	
	public void Dead()
    {
        SceneManager.LoadScene("Final");
    }

	public void startGame()
    {
        SceneManager.LoadScene("Test");
    }
    public void restartGame()
    {
        SceneManager.LoadScene("Test");
    }
}
