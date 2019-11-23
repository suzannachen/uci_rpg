﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
	public Animator animator;

	private int levelToLoad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
        	FadeToNextLevel();
        }
    }

    public void FadeToNextLevel()
    {
    	FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel(int levelIndex)
    {
    	levelToLoad = levelIndex;
    	animator.SetTrigger("Fade Out");
    }

    public void OnFadeComplete()
    {
    	SceneManager.LoadScene(levelToLoad);
    }
}
