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

    private bool isWalking;
    private bool isRunning;


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
            isWalking = true;

            if (anim.GetBool("walk") && isWalking)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    isRunning = true;
                    anim.SetBool("run", true);
                    Movespeed = 13;
                }
                else
                {
                    isRunning = false;
                    anim.SetBool("run", false);
                    Movespeed = 5;
                }

            }

            
        }
        else
        {
            anim.SetBool("walk", false);
            anim.SetBool("run", false);
            isWalking = false;
        }

        lookAt();




    }

    private void JumpPlayer(InputAction.CallbackContext context)
    {
        rb.AddForce(Vector3.up * Jumpspeed, ForceMode.Impulse);
        anim.SetTrigger("jump");
    }
    private void lookAt()
    {
        Vector3 direction = rb.velocity;
        var newRotation = Quaternion.LookRotation(direction, Vector3.up);
        newRotation.x = 0;
        newRotation.z = 0;

        if (playerinput.Player.Movement.ReadValue<Vector2>().sqrMagnitude > 0.1f && direction.sqrMagnitude > 0.1f)
            this.rb.rotation = Quaternion.Slerp(rb.rotation, newRotation.normalized, 0.4f);
        else
            rb.angularVelocity = Vector3.zero;
    }
}
