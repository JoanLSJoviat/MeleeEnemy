using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image fullBar;
    public Image emptyBar;
    private PlayerHealth playerHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
        emptyBar.fillAmount = playerHealth.health / 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        fullBar.fillAmount = playerHealth.currentHealth / 10; 
       // emptyBar.fillAmount = playerHealth.currentHealth / 10;
    }
    
}
