using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    Transform SpawnPoint;

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Respawn"))
        {
            Debug.Log("Triggered!: " + other.gameObject.name);
            transform.position = SpawnPoint.position;
            transform.rotation = SpawnPoint.rotation;
        }      
    }
}
