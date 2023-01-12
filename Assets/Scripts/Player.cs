using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int initialHealth = 100;
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
        _health = initialHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
