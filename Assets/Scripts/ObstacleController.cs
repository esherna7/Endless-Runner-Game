using System;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float moveSpeed = 5f;    // Speed at which obstacle moves toward player
    public float destroyPosition = -15f;    // X-position to destroy obstacle offscreen

    // Update is called once per frame
    void Update()
    {
        // Move obstacle towards player
        transform.Translate(moveSpeed * Time.deltaTime * Vector2.left);
        // Destroy object offscreen
        if(transform.position.x < destroyPosition)
        {
            Destroy(gameObject);
        }
    }
}
