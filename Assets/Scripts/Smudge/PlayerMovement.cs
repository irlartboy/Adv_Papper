using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D cont;
 
    private float horiMove = 0f;
    public float walkSpeed = 150f;
    private bool jump = false;
    private bool crouch = false;
    public Animator anim;
    void Update()
    {
        horiMove = Input.GetAxisRaw("Horizontal") * walkSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            anim.SetBool("isJumping", true);
        }
        else if (Input.GetButtonUp("Jump"))
        {
            jump = false;
            anim.SetBool("isJumping", false);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if(Input.GetAxis("Horizontal") != 0)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }

        /* if(anim.GetBool("isMoving") && (Input.GetAxis("Horizontal") < 0.2f || Input.GetAxis("Horizontal") > -0.2f))
         {
             anim.SetBool("isMoving", false);
         }
         if (!anim.GetBool("isMoving") && (Input.GetAxis("Horizontal") > 0.2f || Input.GetAxis("Horizontal") < -0.2f))
         {
             anim.SetBool("isMoving", true);
         }*/

    }

    void FixedUpdate()
    {
        cont.Move(horiMove * Time.fixedDeltaTime,crouch,jump);
        jump = false;
    }
}
