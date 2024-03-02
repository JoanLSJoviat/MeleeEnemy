using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float currentHealth { get; private set; }

    private Animator _animator;
    void Awake()
    {
        _animator = GetComponent<Animator>();
        currentHealth = health;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            TakeDamage(1);
            _animator.SetTrigger("hurt");
        }
        
    }
    
    public void TakeDamage(float dmg)
    {
        currentHealth -= dmg;
    }
    
    
}
