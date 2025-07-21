using System.Collections;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    Animator doorAnim;
    AudioSource doorAudio;
    private float audioDuration = 1f;
    void Start()
    {
        doorAnim = this.transform.parent.GetComponent<Animator>();
        doorAudio = GetComponent<AudioSource>();
    }
    IEnumerator OneSecAudio()
    {
        doorAudio.Play();
        yield return new WaitForSeconds(audioDuration);
        doorAudio.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnim.SetBool("isOpening", true);
            StartCoroutine(OneSecAudio());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnim.SetBool("isOpening", false);
            StartCoroutine(OneSecAudio());
        }
    }
}
