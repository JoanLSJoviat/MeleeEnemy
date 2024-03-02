using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : Enemy
{
    [Header("Saw:")]
    [SerializeField] private float distance;

    [SerializeField] private float speed;

    private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementSpeed = speed * Time.deltaTime * direction;
        transform.Translate(movementSpeed, 0 ,0);
        if (transform.position.x > distance)
        {
            direction = -direction;
        }

        if (transform.position.x < -distance)
        {
            direction = -direction;
        }
    }
}
