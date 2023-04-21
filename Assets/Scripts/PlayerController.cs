using MatteoBenaissaLibrary.SpriteView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public bool CanTakeWeapon;

    [SerializeField] private bool _haveAxe;
    [SerializeField] private bool _haveM16;

    private Vector3 moveDirection;

    private SpriteView _spriteView;

    void Start()
    {
        _spriteView = GetComponent<SpriteView>();
        CanTakeWeapon = true;
    }

    void Update()
    {
        Move();
        CheckWeapon();
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        moveDirection.x = horizontalInput * moveSpeed * Time.deltaTime;
        moveDirection.y = verticalInput * moveSpeed * Time.deltaTime;

        transform.position += moveDirection;
        _spriteView.PlayState("WalkUnarmed");

    }
    
    private void CheckWeapon()
    {
        if (_haveAxe || _haveM16)
        {
            CanTakeWeapon = false;
            if (_haveAxe)
            {
                _spriteView.PlayState("IdleM16");
            }

            if (_haveM16)
            {
            }
        }
        else
        {
            CanTakeWeapon = true;
        }
    }
}