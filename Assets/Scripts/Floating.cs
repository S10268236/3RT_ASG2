using UnityEngine;

public class Floating : MonoBehaviour
{
    public float speed = 3f;
    public float height = 0.3f;
    private Vector3 startPosition;
    public float rotationSpeed = 60f;
    private void Start()
    {
        startPosition = transform.position;

    }
    private void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time + speed) * height;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
