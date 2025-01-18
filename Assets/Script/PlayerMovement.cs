using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float jumpforce;
    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the player presses and the character is not on the left lane of our track already, then
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -9)
        {
            // Moving the character 9 units to the left
            transform.Translate(-9, 0, 0);
        }
        // If the player presses and the character is not on the right lane of our track already, then
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 9)
        {
            // Moving the character 9 units to the right
            transform.Translate(9, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            // Moving the character 9 units to the right
            rb.AddForce(transform.up * jumpforce,ForceMode.Impulse);
        }
        
        if (rb.velocity.y > 0) 
        {
            anim.SetBool("jump", true);
        }

        if (rb.velocity.y == 0) 
        {
            anim.SetBool("jump", false);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
    }
}
