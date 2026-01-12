using UnityEngine;
using UnityEngine.InputSystem;

public class move_ball : MonoBehaviour
{
    public float speed = 6f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Game Started");
    }

    void FixedUpdate()
    {
        if (Keyboard.current == null)
            return;

        Vector3 move = Vector3.zero;

        if (Keyboard.current.yKey.isPressed)
        {
            move += transform.forward;
            Debug.Log("Moving Forward");
        }
        if (Keyboard.current.hKey.isPressed)
        {
            move -= transform.forward;
            Debug.Log("Moving Backward");
        }
        if (Keyboard.current.gKey.isPressed)
        {
            move -= transform.right;
            Debug.Log("Moving Left");
        }
        if (Keyboard.current.jKey.isPressed)
        {
            move += transform.right;
            Debug.Log("Moving Right");
        }

        if (move != Vector3.zero)
        {
            rb.MovePosition(transform.position + move.normalized * speed * Time.fixedDeltaTime);
        }
    }
}
