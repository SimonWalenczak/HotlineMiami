using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float Speed = 5.0f;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Vector2 movement = new Vector2(horizontal, vertical);
        // _rigidbody.velocity = movement * Speed;
        //
        // if (_rigidbody.velocity != Vector2.zero)
        // {
        //     transform.up = _rigidbody.velocity.normalized;
        // }
        
        transform.position += new Vector3(horizontal * Speed, 0, vertical * Speed).normalized;
    }
}
