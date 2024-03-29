﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Detects when the ball touches the goal, and then win the level
/// </summary>
public class Goal : MonoBehaviour
{
    public GameObject WinText;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Teeech!");
        if (collision.tag == "Player")
        {
            WinText.SetActive(true);
            audioSource.Play();
            Debug.Log("Goal >:(");
            GameOver.isGameOver = true;
        }


    }

}
