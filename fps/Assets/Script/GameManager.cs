using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Data;
using System.Threading;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI TargetText;
    public int winScene;
    public int loseScene;
    private int _targetAmount;
    private Timer _timer;
    // Start is called before the first frame update
    void Start()
    {
       _timer = GameObject.Find("GameManager").GetComponent<timer>();
        Cursor.lockState = CursorLockMode.Locked;
        int floattarget = GameObject.FindGameObjectsWithTag("targetfloat").Length;
        int standtarget = GameObject.FindGameObjectsWithTag("targetstand").Length;
        _targetAmount = floattarget + standtarget;
        TargetText.text = "Tatgets: " + _targetAmount.ToString();
    }

    // Update is called once per frame
    public void updateTargetAmount()
    {
        _targetAmount -=1;
        TargetText.text = "Targets: " + _targetAmount.ToString();
        if(_targetAmount <= 0)
        {
            //stop timer
            GameObject.Find("GameManager").GetComponent<timer>().EndGameTimer();
             

            //send player to the next scene 
        SceneManager.LoadScene(winScene);  
        }
    }

    void Update()
    {
       if(_timer.GetTimeRemaining() <=0)
       {
        SceneManager.LoadScene(loseScene);
       } 
    }
}
