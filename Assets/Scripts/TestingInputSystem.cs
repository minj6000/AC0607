using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class TestingInputSystem : MonoBehaviour
{

    private Rigidbody rb;
    public float jumpspeed = 4f;
    InputTest inputtest;
    [SerializeField] AudioSource au;
    [SerializeField] AudioSource Jumpau;
    [SerializeField] float speed = 7f;


    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
   
        inputtest = new InputTest();
        inputtest.PlayerWalk.Enable();
        inputtest.PlayerWalk.Jump.performed += Jump;
    }


    private void FixedUpdate()
    {
        Vector2 inputVector = inputtest.PlayerWalk.Movement.ReadValue<Vector2>();
        
        rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);

        if(inputVector != Vector2.zero)
        {
            au.Play();
        }
    }


    public void Jump(InputAction.CallbackContext context)
    {
        rb.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
        Jumpau.Play();
    }

   
}
