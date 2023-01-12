using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int initialHealth = 100;
    int _health;
    public int Health
    {
        get { return _health; }
    }

    private void Awake()
    {
        _health = initialHealth;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
