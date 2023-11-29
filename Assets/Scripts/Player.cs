using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float _playerSpeed = 5;
    [SerializeField]private float _jumpForce = 7;
    [SerializeField]private Animator _anim;
    private float _inputHorizontal;
    private Rigidbody2D _rbody2D;

    void Start()
    {
        _rbody2D = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        if (Input.GetButtonDown("Jump") && GroundSensor._isGrounded)
        {
            Jump();
           
        } 
        _anim.SetBool("IsJumping", !GroundSensor._isGrounded);
    }
        
    void FixedUpdate()
    {
       _rbody2D.velocity = new Vector2(_inputHorizontal * _playerSpeed, _rbody2D.velocity.y);
    }

    void PlayerMovement()
    {
        _inputHorizontal = Input.GetAxis("Horizontal");
        
        if(_inputHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            Debug.Log("aas");
            _anim.SetBool("IsRunning", true);
        }
        if(_inputHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            _anim.SetBool("IsRunning", true);
        }
        else
        {
            _anim.SetBool("IsRunning", false);
        }
    }
    void Jump()
    {
        _rbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

}
