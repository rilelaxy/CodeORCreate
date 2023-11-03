using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    Vector2 lastClickedPos;
    bool moving;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }
        
        if (moving)
        {
            // Calculate the direction to move in
            Vector2 moveDirection = (lastClickedPos - (Vector2)transform.position).normalized;
            
            // Calculate the distance to the target position
            float distance = Vector2.Distance(transform.position, lastClickedPos);

            if (distance > 0.1f) // Adjust the threshold for when to stop moving
            {
                // Move the player using Rigidbody2D to handle collisions
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                rb.velocity = moveDirection * speed;
            }
            else
            {
                // Stop moving when close to the target
                moving = false;
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                rb.velocity = Vector2.zero;
            }
        }
    }
}
