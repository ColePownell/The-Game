using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDMG : MonoBehaviour
{
    public float DMG;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

        Enemystatus status = collision.GetComponent<Enemystatus>();

        if(status != null )
        {
            status.life -= DMG;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
