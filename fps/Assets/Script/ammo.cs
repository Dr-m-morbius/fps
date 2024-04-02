using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ammo : MonoBehaviour
{
    public TextMeshProUGUI AmmoText;
    private int _ammoAmount = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateAmmoAmount()
    {
        
    }
    public void RemoveAmmo()
    {
        _ammoAmount -= 1;
        AmmoText.text = _ammoAmount.ToString();
    }
    public void AddAmmo()
    {
        _ammoAmount += 1;
        AmmoText.text = _ammoAmount.ToString();        
    }
}
