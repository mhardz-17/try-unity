using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] ObjectBehavior _objectBehavior;

    float _walkSpeed;
    float _inputHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _walkSpeed = 8.0f;
        _objectBehavior.SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxis("Horizontal");
        if(_inputHorizontal != 0)
        {
            _rb.AddForce(new Vector2(_inputHorizontal * _walkSpeed, 0f));
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision on Player");
    }
}
