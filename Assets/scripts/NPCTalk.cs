using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class NPCTalk : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private bool triggerActive = false;
    public GameObject box;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player?"))
        {
            triggerActive = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player?"))
        {
            triggerActive = false;
        }
    }

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.E))
        {
            SomeCoolAction();
        }
    }

    public void SomeCoolAction()
    {
         box = GameObject.Find("Dialogue");
         box.GetComponent<Dialogue>().startDia();
    }
}
