using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(TankController))]
public class Player : MonoBehaviour
{
    [SerializeField] int _maxHealth = 3;
    int _currentHelath;

    TankController _tankController;
    private void awake()
    {
        _tankController = GetComponent<TankController>();
    }

    // Update is called once per frame
    private void start ()
    {
        _currentHelath = _maxHealth;
    }

    public void IncreaseHealth(int amount)
    {
        _currentHelath += amount; 
        
        _currentHelath = Mathf.Clamp(_currentHelath, 0, _maxHealth);
        Debug.Log("Player's health: " + _currentHelath);

    }
    
    public void DecreaseHealth(int amount)
    {
        _currentHelath -= amount;
        Debug.Log("Player's health: " + _currentHelath);
        if(_currentHelath <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        gameObject.SetActive(false);
        // play particles 
        // play sound
    }

}
