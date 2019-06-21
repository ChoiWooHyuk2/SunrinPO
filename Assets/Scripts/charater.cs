using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charater : MonoBehaviour
{
    public Jump jump;
    public Animator anim;

 
 
    // Start is called before the first frame update
    private void Awake()
    {
        Screen.SetResolution(Screen.width, Screen.width * 9 / 16, true);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
  
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground") {
            jump.Onground = true;
            
        }
      
    }
    



}
