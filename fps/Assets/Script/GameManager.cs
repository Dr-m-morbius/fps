using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI TargetText;
    private int _targetAmount;
    // Start is called before the first frame update
    void Start()
    {
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
        }
    }
}
