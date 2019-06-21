using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
   
    private Transform tr;
    public Transform Ch;
   
    
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {

        tr.position = Ch.position + new Vector3(0, 3.3f , - 10f);

    }

  
}
