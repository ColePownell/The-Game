using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtk : MonoBehaviour
{
    public GameObject prefab;
    public GameObject centerPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnFire()
    {
        GameObject clone = Instantiate(prefab);

        clone.transform.position = centerPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       // if(Input.GetKeyDown(KeyCode.Mouse0))
       // {
       //     Instantiate(prefab, centerPoint.transform.position, centerPoint.transform.rotation);
       // }
    }
}
