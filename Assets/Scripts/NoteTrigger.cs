using UnityEngine;

public class NoteTrigger : MonoBehaviour
{
    public GameObject NoteUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            NoteUI.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            NoteUI.SetActive(false);
    }
}
