using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsMove : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private float currentMovementSpeed;

    private void Start()
    {
        currentMovementSpeed = movementSpeed;
    }


    private void FixedUpdate()
    {
        float speed = -currentMovementSpeed * Time.deltaTime;
        transform.Translate(speed, 0, 0);    
    }

    public void IncreaseSpeed(float size) {
        currentMovementSpeed += size;
    }
}
