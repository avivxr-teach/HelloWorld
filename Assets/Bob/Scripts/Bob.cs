using UnityEngine;

public class Bob : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0f, 2f, 0f);
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        transform.localScale = Vector3.one * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
