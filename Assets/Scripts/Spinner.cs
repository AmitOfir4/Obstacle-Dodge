using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotationSpeed = 0.3f;
    [SerializeField] float zRotationSpeed = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, xRotationSpeed, zRotationSpeed)); // Rotate around the Y-axis
    }
}
