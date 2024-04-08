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
    public int GetAmmoAmount()
    {
        return _ammoAmount;
    }
    public void AddAmmo()
    {
        _ammoAmount += 10;
        AmmoText.text = _ammoAmount.ToString();        
    }

    private void DisplayAmmoText()
    {

        AmmoText.text = "ammo: " + _ammoAmount.ToString();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ammo"))
        {
            Destroy(other.gameObject);
            AddAmmo();
        }
    }
    void OnCollisionEnter(Collision other)
    {
        Destroy(this.gameObject);
    }
}
