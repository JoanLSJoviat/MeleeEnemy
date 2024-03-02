using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float currentHealth;

    private Animator _animator;
    void Awake()
    {
        _animator = GetComponent<Animator>();
        currentHealth = health;

    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    
    public void TakeDamage(float dmg)
    {
        currentHealth -= dmg;
        if (currentHealth == 0)
        {
            _animator.SetTrigger("death");
            gameObject.tag = "Untagged";


        }
        else
        {
            _animator.SetTrigger("hurt");
        }
       
    }
    
    
}
