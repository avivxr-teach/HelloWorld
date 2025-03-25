using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.mass = 10f;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
