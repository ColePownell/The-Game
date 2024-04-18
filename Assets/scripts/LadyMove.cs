using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class LadyMove : MonoBehaviour
{

    public float targetTime = 34.0f;
    public float speed = 1;
    //1 mane right 0 means left
    private int flag = 1;


    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        targetTime = 34.0f;
        Flip();
        if(flag == 1)
        {
            flag = 0;
            speed = -1;
        } else
        {
            flag = 1;
            speed = 1;
        }
        //do your stuff here.
    }

    private void Flip()
    {
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;     
    }
}



