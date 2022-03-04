using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsMove : MonoBehaviour
{
    public float movementSpeed;

    void Update()
    {
        float speed = -movementSpeed * Time.deltaTime;
        transform.Translate(speed, 0, 0);    
    }
}
