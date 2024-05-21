using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    /*
     movespeed = forward, backward
     rotatespeed = left, right
     v input is vertical axis input. h input is horizontal axis input
    jump velocity = how high to jump
    _isJumping = detect if currently jumpig or not
    _col = the player collider 
    _rb = allow to control player's body
    */
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    private float _vInput;
    private float _hInput;

    public float JumpVelocity = 5f;
    private bool _isJumping;
    private CapsuleCollider _col;

    private Rigidbody _rb;
    //[SerializeField]  bool aliveStatus = true;
    public float DistanceToGround = 0.1f;
    public LayerMask GroundLayer;
    // Start is called before the first frame update
    void Start()
    {
        // gain reference to rigidbody/ collider component of player to move it
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (aliveStatus)
        {
            // get value of both vertical and horizontal axis and multiply by move/rotate speed to determine quickness of movement 
            // detect when wasd is pressed and value of 1/-1 of W/S keys respectively multipled by move/rotate speed
            _vInput = Input.GetAxis("Vertical") * MoveSpeed;
            _hInput = Input.GetAxis("Horizontal") * RotateSpeed;

            // allows jump to occur once after holding space down
            _isJumping |= Input.GetKeyDown(KeyCode.Space);
        }

    }

    void FixedUpdate()
    {
        // move and rotate object for each next frame at a constant speed
        // left/right rotation axis

        if (aliveStatus)
        {

        
            Vector3 rotation = Vector3.up * _hInput;
            Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

            // direction annd speed the player will move throughout z axis 
            _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
            _rb.MoveRotation(_rb.rotation * angleRot);

            // allow player to jump under forces like gravity and jump velocity
            if (IsGrounded() && _isJumping)
            {
                _rb.AddForce(Vector3.up * JumpVelocity,
                ForceMode.Impulse);
            }
            // if not jumping, state is at rest
            _isJumping = false;
        }

    }

        // detect collision between collider and ground layer
        bool IsGrounded()
        {
            // store collider bottom position
            Vector3 capsuleBottom = new Vector3(_col.bounds.center.x,
            _col.bounds.min.y, _col.bounds.center.z);

            // check if collider is grounded based on closeness to ground
            bool grounded = Physics.CheckCapsule(_col.bounds.center,
            capsuleBottom, DistanceToGround, GroundLayer, QueryTriggerInteraction.Ignore);

            return grounded;


        }
    /*
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Mob")
            {
                Debug.Log("You died!");
                aliveStatus = false;
                Die();

            }
        }

        void Die()
        { 
         Destroy(this.gameObject);
        Time.timeScale = 0f;
        Application.Quit();
        }
    */
    }
