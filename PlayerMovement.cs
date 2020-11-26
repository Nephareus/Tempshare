using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float Speed = 10f;

    public Rigidbody2D rb;

    // bool for changing to animation for pushing items
    public bool isPushing = false;

    public Animator anim;
    private Vector2 vel;
    private Vector2 direction;

    private void Update()
    {
        anim.SetFloat("Horizontal", vel.x);
        anim.SetFloat("Vertical", vel.y);
        anim.SetFloat("Speed", vel.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        {
            rb.MovePosition(rb.position + vel * Speed * Time.fixedDeltaTime);
        }
    }
    public void Move(InputAction.CallbackContext context)
    {

        vel = context.ReadValue<Vector2>();
    }
}
