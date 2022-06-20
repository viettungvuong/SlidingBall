using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game instance;
    public static int score=0;
    public GameObject scoreText, bestText, gameOverPanel, road;
    public GameObject player;
    private float nextActionTime = 0.0f;
    public float period = 0f;
    private void Awake()
    {
        Time.timeScale = 1; //de khi replay lai
        gameOverPanel.SetActive(false);
        instance = this;
        Application.targetFrameRate = 120;
        score = 0;
        float c = Random.Range(0, 10.5f);
        road.gameObject.GetComponent<Renderer>().material.SetFloat("Vector1_B4EC16BA", c);
    }
    void Start()
    {
        Color color;
        int c = Random.Range(0, 7);
        switch (c)
        {
            case 0:
                {
                    color = Color.green;
                    break;
                }
            case 1:
                {
                    color = Color.yellow;
                    break;
                }
            case 2:
                {
                    color = Color.blue;
                    break;
                }
            case 3:
                {
                    color = Color.red;
                    break;
                }
            case 4:
                {
                    color = Color.white;
                    break;
                }
            case 5:
                {
                    color = Color.magenta;
                    break;
                }
            default:
                {
                    color = Color.cyan;
                    break;
                }
        }
        player.gameObject.GetComponent<Renderer>().material.SetColor("Color_d3f90b46fa4040c48d4031973961bef6", color);
        player.gameObject.GetComponent<Renderer>().material.SetColor("Color_64d861fce71044349695d1bac7f2ea98", color * 0.9f);

    }

    // Update is called once per frame
    void Update()
    {
        if (period > 1f) //cu moi mot giay se cong diem
        {
            //Do Stuff
            period = 0;
            score++;
        }
        period += UnityEngine.Time.deltaTime;
        scoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }

    public void Lose()
    {
        if (PlayerPrefs.GetInt("HighScore", 0) < score)
            PlayerPrefs.SetInt("HighScore", score);
        gameOverPanel.SetActive(true);
        bestText.GetComponent<TextMeshProUGUI>().text = "Best: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        Time.timeScale = 0;
    }

}
