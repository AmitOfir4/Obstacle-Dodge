using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float flySpeed;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flySpeed = 5f;
        playerPosition = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsPlayer();
        DestroyWhenReached();
    }

    void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, flySpeed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
