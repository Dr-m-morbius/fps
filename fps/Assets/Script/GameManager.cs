using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
 public TextMeshProUGUI targetText;
    public int winScene;
    public int loseScene;
    private int _targetAmount;
    private timer _timer;

    // Start is called before the first frame update
    void Start()
    {
        _timer = GameObject.Find("GameManager").GetComponent<timer>();
        Cursor.lockState = CursorLockMode.Locked;
        int floatingTarget = GameObject.FindGameObjectsWithTag("targetfloat").Length;
        int standingTarget = GameObject.FindGameObjectsWithTag("targetstand").Length;
        _targetAmount = floatingTarget + standingTarget;
        targetText.text = "Targets: " + _targetAmount.ToString();
    }

    void Update()
    {
        if(_timer.GetTimeRemaining() <= 0)
        {
            SceneManager.LoadScene(loseScene);
        }
    }

    public void UpdateTargetAmount()
    {
        _targetAmount -= 1;
        targetText.text = "Targets: " + _targetAmount .ToString() ;

        if(_targetAmount <= 0)
        {
            //stop the timer
            GameObject.Find("GameManager").GetComponent<timer>().EndGameTimer();

            //Send player to the win scene
            SceneManager.LoadScene(winScene);
        }
    }
}