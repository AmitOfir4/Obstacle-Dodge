using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }
    void movePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * 6f; 
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * 6f;

        transform.Translate(xValue , yValue, zValue); // Move the player based on input
    }
}
