using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // movespeed = forward, backward
    // rotatespeed = left, right
    // v input is vertical axis input. h input is horizontal axis input
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    private float _vInput;
    private float _hInput;

    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        // gain reference to rigidbody component of player to move it
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // get value of both vertical and horizontal axis and multiply by move/rotate speed to determine quickness of movement 
        // detect when wasd is pressed and value of 1/-1 of W/S keys respectively multipled by move/rotate speed
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;

    }

    void FixedUpdate()
    {
        // move and rotate object for each next frame at a constant speed
        // left/right rotation axis
        Vector3 rotation = Vector3.up * _hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        // direction annd speed the player will move throughout z axis 
        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);
    }
}
