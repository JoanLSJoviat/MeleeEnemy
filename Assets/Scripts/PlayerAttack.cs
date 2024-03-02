using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackDelay;
    [SerializeField] private Transform firePoint;
    [SerializeField] private Projectile[] fireBalls;
    [SerializeField] private AudioClip _launchFireballSound;
    private AudioSource _audioSource;
    
    private float attackTimer = Mathf.Infinity;
    private Animator anim;
    private PlayerMovement _playerMovement;
 
    
    
    // Start is called before the first frame update
    private void Awake()
    {
        anim = GetComponent<Animator>();
        _playerMovement = GetComponent<PlayerMovement>();
        _audioSource = GetComponent<AudioSource>();
       

    }

    // Update is called once per frame
    void Update()
    {
        attackTimer += Time.deltaTime;
        if (Input.GetMouseButton(0) && attackTimer > attackDelay && _playerMovement.canAttack())
        {
          //  _audioSource.PlayOneShot(_launchFireballSound);
            Attack();
        }
        
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        Debug.Log("ATTACK");
        attackTimer = 0.0f;

        int index = FindFireball();
        fireBalls[index].transform.position = firePoint.position;
        fireBalls[index].SetDirection(Mathf.Sign(transform.localScale.x));
        
    }

    private int FindFireball()
    {
        for (int i = 0; i < fireBalls.Length; i++)
        {
            if (!fireBalls[i].gameObject.activeInHierarchy)
            {
                return i;
            }
        }

        return 0;
    }
}
