using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public GameManager manager;

    [Header("Stats Player")]
    public int health = 100;


    [Header("Sliders")]
    public Slider sliderHealth;
    public GameObject loseUI;


    void Start()
    {
        health = 100;
        //loseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        //LevelUp();
        //Lose();
    }

    void Lose()
    {
        if (health <= 0)
        {
            loseUI.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    public void MainMenu()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    
}
