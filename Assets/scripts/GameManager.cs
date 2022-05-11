using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private int score;
    public Text Scoretext;
    public GameObject Playbuttom;
    public GameObject gameover;
    public GameObject space;
    public GameObject Retry;
    public GameObject troncos;
    public player player;
    public AudioSource boton;
    public GameObject exit;
    public GameObject tittle;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        space.SetActive(true);
        gameover.SetActive(false);
        Retry.SetActive(false);
        exit.SetActive(false);
        tittle.SetActive(true);
        exit.SetActive(true);
        Pause();
    }

    public void Play()
    {
        
        score = 0;
        Scoretext.text = score.ToString();
        gameover.SetActive(false);
        Playbuttom.SetActive(false);
        space.SetActive(false);
        Retry.SetActive(false);
        exit.SetActive(false);
        tittle.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        troncos[] Troncos = FindObjectsOfType<troncos>();

        for (int i = 0; i < Troncos.Length; i++)
        {
            Destroy(Troncos[i].gameObject);
        }

        boton.Play();
    }


    public void playboton()
    {
        boton.Play();
    }
    

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }


    public void Gameover()
    {
        gameover.SetActive(true);
        Retry.SetActive(true);
        exit.SetActive(true);
        Pause();
    }


    public void ResetButton()
    {
        SceneManager.LoadScene("gameplay");
    }




    public void increasscore()
    {
        score++;
        Scoretext.text = score.ToString();

    }

    public void exitgame()
    {
        Application.Quit();
    }

}