using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        score++;
        Debug.Log("Collision detected with: " + collision.gameObject.name + ". Current score: " + score);
    }
}
