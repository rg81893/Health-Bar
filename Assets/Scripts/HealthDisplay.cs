using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text healthDisplay;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = new Player();
        healthDisplay.text = player.Health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
