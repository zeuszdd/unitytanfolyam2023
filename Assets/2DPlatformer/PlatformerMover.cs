using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMover : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float acceleration = 10;
    [SerializeField] float deceleration = 10;
    [SerializeField] float maxSpeed = 10;
    [SerializeField] float jumpSpeed = 10;
    [SerializeField] new Rigidbody2D rigidbody;

    bool isGrounded = false;

    private void OnValidate()
    {
        if (rigidbody == null)
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        Vector2 velocity = rigidbody.velocity;
        
        if (x==0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, deceleration * Time.deltaTime);
        }
        else
        {
            Vector2 accelerationVec = new Vector2(x * acceleration, 0);
            velocity += accelerationVec * Time.deltaTime;
            if (Mathf.Abs(velocity.x)>maxSpeed)
            {
                velocity.x = maxSpeed * Mathf.Sign(velocity.x);
            }
        }

        bool jump = Input.GetKeyDown(KeyCode.Space);

        if (jump && isGrounded)
        {
            velocity.y = jumpSpeed;
        }

        rigidbody.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
