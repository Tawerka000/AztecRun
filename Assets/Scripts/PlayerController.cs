using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;
    public bool isRunning;
    [SerializeField] private float _moveSpeed;
    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("isRunning", true);
        }
        else
            _animator.SetBool("isRunning", false);
       
        }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            _animator.SetBool("obj", true);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            _animator.SetBool("obj", false);
        }
    }
}
