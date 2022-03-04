using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speedUpForce;
    
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if(transform.position.y < 3.6f)
            {
                rb.velocity = Vector2.up * speedUpForce;
            }
        }
    }
}
