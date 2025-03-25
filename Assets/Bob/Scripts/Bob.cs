using UnityEngine;

public class Bob : MonoBehaviour
{
    public float speed = 2f;
    public float roationSpeed = 360f;
    void Update()
    {
        //transform.position += Vector3.up * speed * Time.deltaTime;
      //  transform.Translate(Vector3.up * speed * Time.deltaTime);
        transform.Rotate(new Vector3(0,1,0)* roationSpeed*Time.deltaTime);
    }
}
    