using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    Animator doorAnim;
    void Start()
    {
        doorAnim = this.transform.parent.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnim.SetBool("isOpening", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnim.SetBool("isOpening", false);
        }
    }
}
