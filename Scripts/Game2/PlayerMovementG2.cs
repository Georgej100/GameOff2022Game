using UnityEngine;

public class PlayerMovementG2 : MonoBehaviour
{

    [SerializeField] float Speed;
    [SerializeField] float JumpSpeed; 
    [SerializeField] float MinSpeed;
    [SerializeField] float MinX;
    [SerializeField] float MaxX;
    [SerializeField] float MaxSpeed;
    [SerializeField] Rigidbody2D Rb;
    bool IsTouching;

    void Update()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }

        float Horizontal = Input.GetAxis("Horizontal") * Speed;
        Rb.velocity = new Vector2(Horizontal, Rb.velocity.y);
        CheckIfInBounds();
    }

    bool IsGrounded()
    {
        if(Rb.velocity.y > MinSpeed && Rb.velocity.y < MaxSpeed || Rb.velocity.y == 0)
        {
            IsTouching = true;
        }
        else
        {
            IsTouching = false;
        }
        return IsTouching;
    }

    void Jump()
    {
        Rb.velocity = new Vector2(Rb.velocity.x, JumpSpeed);
        IsTouching = false;
    }

    void CheckIfInBounds()
    {
        if (transform.position.x > MaxX)
        {
            transform.position = new Vector3(MaxX, Rb.position.y, 0);
        }

        if (transform.position.x < MinX)
        {
            transform.position = new Vector3(MinX, Rb.position.y, 0);
        }
    }
}
