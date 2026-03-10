using UnityEngine;
using UnityEngine.InputSystem;

public class torque : MonoBehaviour
{
    [SerializeField] public float torquePower;
    Rigidbody rb;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(0,0,torquePower);
        }
    }
}
