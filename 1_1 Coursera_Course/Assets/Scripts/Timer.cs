using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    #region Fields
    // timer duration
    float totalSeconds = 0;

    // timer execution
    float elapsedSeconds = 0;
    bool running = false;

    // support for Finished property
    bool started = false;

    #endregion

    #region Properties

    // Sets the duration of the timer, as long as it's nto currently running.
    public float Duration
    {
        set
        {
            if (!running)
            {
                totalSeconds = value;
            }
        }
    }

    public bool Finished
    {
        get { return started && !running; }
    }

    public bool Running
    {
        get { return running; }
    }
    #endregion

    #region Methods

    void Update()
    {
        //update the timer and check to see if it's finished.
        if (running)
        {
            elapsedSeconds += Time.deltaTime;
            if(elapsedSeconds >= totalSeconds)
            {
                running = false;
            }
        }
    }

    /// Runs the timer
    /// Because a timer of 0 duration doesn't really make sense,
    /// the timer only runs if the total seconds is larger than 0
    /// This also makes sure the consumer of the class has actually 
    /// set the duration to something higher than 0
    public void Run()
    {
        // only run with valid duration
        if(totalSeconds > 0)
        {
            running = true;
            started = true;
            elapsedSeconds = 0;
        }
    }

    #endregion

}
