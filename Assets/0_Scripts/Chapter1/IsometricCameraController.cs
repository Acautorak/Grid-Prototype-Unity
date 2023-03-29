using UnityEngine;

public class IsometricCameraController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 90f;
    public float rotationSmoothness = 10f;

    private Vector3 cameraPosition;
    private Quaternion targetRotation;

    void Start()
    {
        cameraPosition = transform.position;
        targetRotation = transform.rotation;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal != 0 || vertical != 0)
        {
            float x = horizontal * Time.deltaTime * moveSpeed;
            float z = vertical * Time.deltaTime * moveSpeed;
            Vector3 moveVector = transform.forward * z + transform.right * x;

            cameraPosition += moveVector;
        }

        Vector3 rotationVector = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.Q))
        {
            rotationVector.y += 1;
        }

        if (Input.GetKey(KeyCode.E))
        {
            rotationVector.y -= 1;
        }



        transform.eulerAngles += rotationVector * rotateSpeed * Time.deltaTime;
        transform.position = cameraPosition;
    }
}


//targetRotation *= Quaternion.Euler(rotateSpeed / 2, -rotateSpeed, 0f);