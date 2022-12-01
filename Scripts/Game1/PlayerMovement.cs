using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float Speed;
    [SerializeField] float MinX;
    [SerializeField] float MaxX;
    [SerializeField] Rigidbody2D Rb;
    [SerializeField] Transform Transform;

    void Start()
    {
        
    }
    
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal") * Speed;
        Rb.velocity = new Vector3(Horizontal, 0, 0);
        CheckIfInBounds();
    }

    void CheckIfInBounds()
    {
        if(transform.position.x > MaxX)
        {
            Transform.position = new Vector3(MaxX, -5, 0);
        }

        if (transform.position.x < MinX)
        {
            Transform.position = new Vector3(MinX, -5, 0);
        }
    }
}
