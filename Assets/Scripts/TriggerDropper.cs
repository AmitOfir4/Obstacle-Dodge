using UnityEngine;

public class TriggerDropper : MonoBehaviour
{
    [SerializeField] GameObject dropper;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dropper.SetActive(true);
        }
    }
}
