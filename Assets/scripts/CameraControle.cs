using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControle : MonoBehaviour
{
    public float targetTime = 5.0f;
    public GameObject tPlayer;
    public Transform tFollowTarget;
    private CinemachineVirtualCamera vcam;
    private int flag = 1;
    // Start is called before the first frame update
    void Start()
    {
        //vcam = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (flag == 1)
        {
            targetTime -= Time.deltaTime;
            vcam.tr
            if (targetTime <= 0.0f)
            {
                flag = 0;
                playerFollow();
            }
        }*/
    }

    public void playerFollow()
    {
        //tPlayer = GameObject.FindWithTag("Player?");
        tFollowTarget = tPlayer.transform;
        vcam.LookAt = tFollowTarget;
        vcam.Follow = tFollowTarget;
    }
}
