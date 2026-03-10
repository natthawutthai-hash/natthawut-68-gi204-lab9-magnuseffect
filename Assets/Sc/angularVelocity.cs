using UnityEngine;
using UnityEngine.InputSystem;

public class angularVelocity : MonoBehaviour
{
    [SerializeField] public float augularSpeed;
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        if (Keyboard.current.qKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, augularSpeed, 0);
        }
        else
        {
           rb.angularVelocity = Vector3.zero;
        }   
    }
}
