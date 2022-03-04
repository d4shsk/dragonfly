using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsMove : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private void FixedUpdate()
    {
        float speed = -movementSpeed * Time.deltaTime;
        transform.Translate(speed, 0, 0);    
    }

    public void IncreaseSpeed(float size) {
        movementSpeed += size;
    }
}
