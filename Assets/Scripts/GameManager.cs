using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_Text killsText;
    public TMP_Text time;
    public TMP_Text damageText;
    public TMP_Text speedText;
    public int kills = 0;
    public GameObject winUI;
    public AudioSource music;
    public Slider volumeSlider;
    //public GameObject powerUps;


    private float maxTime = 300f;     // Tiempo total del juego (en segundos)

    private float leftTime;
    private bool activeTime = true;



    void Start()
    {
        leftTime = maxTime;
        winUI.SetActive(false);
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    void Update()
    {

        if (activeTime)
        {
            leftTime -= Time.deltaTime;


            if (leftTime <= 0)
            {
                leftTime = 0;
                activeTime = false;
                Win();
            }
            UpdateTime();
        }

    }
    public void SetVolume(float volume)
    {
        music.volume = volume; // Ajusta volumen
    }

    void UpdateTime()
    {
        int minutes = Mathf.FloorToInt(leftTime / 60);
        int seconds = Mathf.FloorToInt(leftTime % 60);

        string tiempoTexto = string.Format("{0:00}:{1:00}", minutes, seconds);

        time.text = tiempoTexto;
    }

    void Win()
    {
        winUI.SetActive(true);
        Time.timeScale = 0f;
    }



    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void UpdateKills()
    {
        kills++;
        UpdateKillText();
    }
    void UpdateKillText()
    {
        if (killsText != null)
        {
            killsText.text = kills.ToString();
        }
    }

    public void UpdateDamageText(int damage)
    {
        if (damageText != null)
        {
            damageText.text = damage.ToString();
            damage += 5;
        }
    }

    public void UpdateSpeedText(int speed)
    {
        if (speedText != null)
        {
            speedText.text = speed.ToString();
            speed += 1;
        }
    }
}
