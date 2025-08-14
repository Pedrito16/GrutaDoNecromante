using UnityEngine;
 
public class Movimento : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float boostMultiplier = 2f;
    public float mouseSensitivity = 3f;
    public bool requireRightMouse = true;

    private float rotationX;
    private float rotationY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        rotationX += Input.GetAxis("Mouse X") * mouseSensitivity;
        rotationY -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotationY = Mathf.Clamp(rotationY, -90f, 90f);

        transform.rotation = Quaternion.Euler(rotationY, rotationX, 0f);

        // Movement
        Vector3 direction = new Vector3(
            Input.GetAxis("Horizontal"),
            (Input.GetKey(KeyCode.E) ? 1 : 0) - (Input.GetKey(KeyCode.Q) ? 1 : 0),
            Input.GetAxis("Vertical")
        );

        float speed = movementSpeed * (Input.GetKey(KeyCode.LeftShift) ? boostMultiplier : 1f);
        transform.Translate(direction * speed * Time.deltaTime, Space.Self);
    }
}
