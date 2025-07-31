using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        
        //meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        makeObjectFall();
    }

    void makeObjectFall()
    {
        meshRenderer.enabled = true;
        rigidBody.useGravity = true;
    }
}