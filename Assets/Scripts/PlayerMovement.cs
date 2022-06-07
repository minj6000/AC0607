using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent (typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    PlayerInput playerinput;
    [SerializeField] float Jumpspeed;
    [SerializeField] float Movespeed;
    private Rigidbody rb;
    private Vector2 Inputvalue;
    public Animator anim;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerinput = new PlayerInput();
        playerinput.Enable();
        playerinput.Player.Jump.performed += JumpPlayer;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Inputvalue = playerinput.Player.Movement.ReadValue<Vector2>();
        rb.AddForce(new Vector3(Inputvalue.x, 0, Inputvalue.y) * Movespeed, ForceMode.Force);
        if (Inputvalue != Vector2.zero)
        {
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }
    }

    private void JumpPlayer(InputAction.CallbackContext context)
    {
        rb.AddForce(Vector3.up * Jumpspeed, ForceMode.Impulse);
        anim.SetTrigger("jump");
    }

}
