using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxX : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
            _rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        if (col.gameObject.tag == "Box")
            _rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
            _rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        if (col.gameObject.tag == "Box")
            _rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
            _rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        if (col.gameObject.tag == "Box")
            _rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
