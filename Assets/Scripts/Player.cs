using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int initialHealth;
    int _health;
    public int Health 
    {
        get 
        { 
            return _health; 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        initialHealth = 100;
        _health = initialHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
