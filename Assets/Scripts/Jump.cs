using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jump : MonoBehaviour, IPointerDownHandler , IPointerUpHandler
{
    public Rigidbody2D Rg;
    public bool Onground = true;
  
    private class AnimState
    {
        public string dirX = "DirX";
        public string dirY = "DirY";
        public string sleep = "Sleep";
        public string jump = "Jump";
    }
    public Animator anim;
    public Animator Input_anim;
 
    [SerializeField] private AnimState animState;
    private float speed = 9.0f;
  

   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void OnPointerDown(PointerEventData eventData)
    {

        if (Onground)

        {
            Input_anim.SetBool("Input", true);
            StartCoroutine("JumpAnim");
            Rg.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
            Onground = false;
        }
    }
    
 

    IEnumerator JumpAnim()
    {

        anim.SetBool("Walking",false);
        anim.SetBool("Jump", true);
        yield return new WaitForSeconds(1.0f);
        anim.SetBool("Jump", false);
        

    }

    public void OnPointerUp(PointerEventData eventData)
    {
       
        Input_anim.SetBool("Input", false);

       
    }
    





}
