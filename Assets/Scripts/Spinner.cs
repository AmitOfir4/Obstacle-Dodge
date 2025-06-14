using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 0.3f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed, 0)); // Rotate around the Y-axis
    }
}
