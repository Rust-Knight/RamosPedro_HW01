using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(TankController))]
public class Player : MonoBehaviour
{
    [SerializeField] int _maxHealth = 3;
    int _currentHealth;

    TankController _tankController;
    private void Awake()
    {
        _tankController = GetComponent<TankController>();
    }

    // Update is called once per frame
    private void Start ()
    {
        _currentHealth = _maxHealth;
    }

    public void IncreaseHealth(int amount)
    {
        _currentHealth += amount;

        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        Debug.Log("Player's health: " + _currentHealth);

    }
    
    public void DecreaseHealth(int amount)
    {
        _currentHealth -= amount;
        Debug.Log("Player's health: " + _currentHealth);
        if(_currentHealth <= 0)
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

    public void addCoinPoints()
    {
        ScoreManager.instance.AddPoint();
    }

    public void slowPlayer()
    {

    }
}
