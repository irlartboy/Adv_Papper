using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D cont;
 
    private float horiMove = 0f;
    public float walkSpeed = 150f;
    private bool jump = false;
    private bool crouch = false;

    void Update()
    {
        horiMove = Input.GetAxisRaw("Horizontal") * walkSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        cont.Move(horiMove * Time.fixedDeltaTime,crouch,jump);
        jump = false;
    }
}
