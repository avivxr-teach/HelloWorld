using UnityEngine;


namespace avivXR
{
    public class SimpleMovement : MonoBehaviour
    {
        public float moveSpeed = 5f;
        public float rotationSpeed = 100f;

        void Update()
        {
            // Movement (WASD or Arrow Keys)
            float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right
            float moveZ = Input.GetAxis("Vertical");   // W/S or Up/Down

            transform.Translate(Vector3.forward *moveZ * moveSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up,moveX*rotationSpeed*Time.deltaTime);



        }
    }
}
