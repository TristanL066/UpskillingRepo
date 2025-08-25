using UnityEngine;
using UnityEngine.InputSystem;

public class PersonJump : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rigidBody.linearVelocity = Vector2.up * 10;
        }
    }
}
