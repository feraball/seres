﻿using DigitalRuby.SoundManagerNamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryController : VideoController {

    public GameObject pauseButton;
    public GameObject playButton;

    bool isPaused = false;

    // Use this for initialization
    void Start () {
        panel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (!isPaused)
        {
            if (player.time >= 197.0f)
            {
                panel.SetActive(true);
                if (player.time >= 207.0f)
                {
                    base.StopAndGoToScene("ActivityHub");
                    //player.time = 198.0f;
                    //player.Pause();
                }
            }
            else
            {
                if (Input.GetMouseButtonUp(0))
                {
                    if (panel.activeSelf == false)
                    {
                        panel.SetActive(true);
                    }
                    else
                    {
                        panel.SetActive(false);
                    }
                }
            }
            
        }
        else
        {
            panel.SetActive(true);
        }

    }

    public void Pause()
    {
        AudioManager.Instance.PlaySFX("TinyButtonPush");
        player.Pause();
        pauseButton.SetActive(false);
        playButton.SetActive(true);
        isPaused = true;
    }

    public void UnPause()
    {
        AudioManager.Instance.PlaySFX("TinyButtonPush");
        player.Play();
        pauseButton.SetActive(true);
        playButton.SetActive(false);
        isPaused = false;
    }

    public void Avanza()
    {
        player.time = 195.0f;
    }

}