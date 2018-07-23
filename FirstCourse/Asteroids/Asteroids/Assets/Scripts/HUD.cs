using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    //[SerializeField]
    //Text scoreText;

    [SerializeField]
    Text gameTimerText;

    Timer gameTimer;

    public bool GameTimer
    {
        set
        {
            gameTimer.Running = false;
        }
        get { return gameTimer.Running; }
    }

    //int score;
    //const string ScorePrefix = "Score: ";

	// Use this for initialization
	void Start ()
    {
        //.text = ScorePrefix + score.ToString();
        gameTimer = gameObject.AddComponent<Timer>();
        gameTimer.Duration = 200;
        gameTimer.Run();
       

	}

    void Update()

    {
        Debug.Log(gameTimer.Running);
        if (gameTimer.Running)
        {
            string timerString = timeText(gameTimer.ElapsedSeconds);
            gameTimerText.text = timerString;
        }

    }
	
	public void AddPoints(int points)
    {
        //score += points;
        //scoreText.text = ScorePrefix + score.ToString();
    }

    public string timeText(float time)
    {

        if (time > 60)
        {
            float mins = time / 60;
            float secs = time % 60;
            return mins.ToString("F0") + ":" + secs.ToString("F2");
        }
        else
        {
            return time.ToString("F2");
        }
        
    }
}
