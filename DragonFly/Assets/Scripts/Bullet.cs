using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float motionSpeed;
    [SerializeField] private float distance;
    [SerializeField] private float lifetime;

    [SerializeField] private LayerMask whatIsSolid;

    private float currentTime;

    void FixedUpdate()
    {
        Destroy(gameObject, lifetime);

        BulletMove();
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            hitInfo.collider.TryGetComponent<CloudDestroy>(out CloudDestroy cloudDestroy);
            if (cloudDestroy)
            {
                cloudDestroy.TakeDamage();
            }
            Destroy(gameObject);
        }
    }

    private void BulletMove()
    {
        transform.Translate(Vector2.right * motionSpeed * Time.deltaTime);
    }
}
