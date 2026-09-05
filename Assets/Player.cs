using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpP = 300f;

    Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Keyboard.current != null &&
            Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rbody.AddForce(Vector2.up * jumpP);
        }
    }

    private void FixedUpdate()
    {
        float move = 0f;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            move = -1f;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            move = 1f;
        }

        rbody.linearVelocity = new Vector2(move * speed, rbody.linearVelocity.y);
    }
}