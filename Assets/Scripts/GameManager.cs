using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] int score;
    [SerializeField] private GameObject GameOverObj;
    [SerializeField] private GameObject startObj;
    Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
        player.enabled = false;
        Time.timeScale = 0;
        startObj.SetActive(true);
    }

    public void StartButton(){
        Time.timeScale = 1;
        player.enabled = true;
        GameOverObj.SetActive(false);
        startObj.SetActive(false);
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void GameOver(){
        GameOverObj.SetActive(true);
        Time.timeScale = 0;
        player.enabled = false;
    }

    public void RestartButton(){
        SceneManager.LoadScene(0);
    }

    public void Scoring(){
        score++;
        scoreText.text = score.ToString();
    }
}
