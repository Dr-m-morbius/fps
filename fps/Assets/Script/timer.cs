using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public float timeRemaining = 60f; 
    public TextMeshProUGUI timertext;
    private bool isTimerRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isTimerRunning)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                isTimerRunning = false;
            }
        }
    }

    public void StartGameTimer()
    {
        isTimerRunning = true;
    }

    public void EndGameTimer()
        {
            isTimerRunning = false;
        }

        private void DisplayTime(float timeToDisplay)
        {
            timeToDisplay += 1;

            float minutes = Mathf.FloorToInt(timeToDisplay /60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60); 

            timertext.text = string.Format("{0;00:}");
        }
    
}
