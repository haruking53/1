using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int life;
    public GameObject ballPrefab;
    public TextMeshProUGUI textGameover;

    private int score;
    private TextMeshProUGUI textScore;

    private TextMeshProUGUI textBalls;
    private bool inGame;

    private float remainTime;
    private TextMeshProUGUI textTime;

    public TextMeshProUGUI textClear;

    private AudioSource audioSource;
    public AudioClip gameOverSound;
    public AudioClip killBallSound;
    public AudioClip gameClearSound;


    private void Start()
    {
        life=3;
        textGameover.enabled=false;
        textClear.enabled=false;

        score=0;
        remainTime=30.0f;
        audioSource=gameObject.AddComponent<AudioSource>();

        textScore=GameObject.Find("Score").GetComponent<TextMeshProUGUI>();

        textBalls=GameObject.Find("Balls").GetComponent<TextMeshProUGUI>();

        textTime=GameObject.Find("Time").GetComponent<TextMeshProUGUI>();


        SetScoreText(score);
        SetBallsText(life);
        inGame=true;
    }

    void Update()
    {
        if(inGame==true)
        {
            remainTime-=Time.deltaTime;
            textTime.text="Time:"+(remainTime>0.0f? remainTime.ToString("0.00"):"0.00");
            
            if(remainTime<0.0f)
            {
                audioSource.PlayOneShot(gameOverSound);
                textGameover.enabled=true;
                inGame=false;
            }
        GameObject ballObj=GameObject.Find("Ball");

        if(ballObj==null)
        {
            --life;
            SetBallsText(life);

            if(life>0)
            {
            audioSource.PlayOneShot(killBallSound);
            GameObject newBall=Instantiate(ballPrefab);
            newBall.name=ballPrefab.name;
            }
            else
            {
                life=0;
                audioSource.PlayOneShot(gameOverSound);
                textGameover.enabled=true;
                inGame=false;
            }
        }
        GameObject targetObj=GameObject.FindWithTag("Target");
        if(targetObj==null)
        {
            audioSource.PlayOneShot(gameClearSound);
            textClear.enabled=true;
            inGame=false;
        }
        }
    }
    private void SetScoreText(int score)
    {
        textScore.text="Score:"+score.ToString();
    }

    private void SetBallsText(int life)
    {
        textBalls.text="Balls:"+life.ToString();
    }

    public void AddScore(int point)
    {
        if(inGame==true)
        {
        score+=point;
        SetScoreText(score);
        }
    }

    public bool CheckinGame()
    {
        return inGame;
    }

}
