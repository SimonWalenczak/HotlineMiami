using System;
using UnityEditor.Animations;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float Speed = 5.0f;
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    
    [SerializeField] private bool _haveAxe;
    [SerializeField] private bool _haveM16;
    public bool CanTakeWeapon;
    private static readonly int IsIdle = Animator.StringToHash("isIdle");

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {

        if (_haveAxe || _haveM16)
        {
            CanTakeWeapon = false;
            if (_haveAxe)
            {
                
            }

            if (_haveM16)
            {
                
            }
        }
        else
        {
            NoWeapon();
        }
    }

    public void NoWeapon()
    {
        CanTakeWeapon = true;
        _animator.SetBool(IsIdle, true);
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
        
        transform.position += new Vector3(horizontal, vertical,0).normalized;
    }
}
