using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D myRigidbody = null;
    [SerializeField] float speed = 3f;
    private Vector3 movement;
    
    void Update()
    {
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
    private void FixedUpdate()
    {
        myRigidbody.MovePosition(transform.position + movement * speed * Time.fixedDeltaTime);
    }
}
