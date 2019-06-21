using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class joystick : MonoBehaviour , IPointerDownHandler , IPointerUpHandler , IDragHandler
{
    [SerializeField] private RectTransform Rect_BackGround;
    [SerializeField] private RectTransform Rect_joystick;
    public bool Onground = true;
    private class AnimState
    {
        public string dirX = "DirX";
        public string dirY = "DirY";
        public string sleep = "Sleep";
        public string jump = "Jump";
    }
    public Animator anim;
   
    private bool AnimationCounter = false;
    [SerializeField] private AnimState animState;
    public Transform play;
    private float rd;
    private bool touch = false;
    private Vector2 movePostion;
    [SerializeField] private GameObject player;
    [SerializeField] private float speed;
    public Jump jump;
   
    
    // Start is called before the first frame update
    void Start()
    {
        rd = Rect_BackGround.rect.width * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (touch) {
            player.transform.position = (Vector2)player.transform.position + movePostion;
          
        }
    }


    public void OnDrag(PointerEventData eventData)
    {
      

        touch = true;



        Vector2 value = eventData.position - (Vector2)Rect_BackGround.position;
        value = Vector2.ClampMagnitude(value,rd);
        Rect_joystick.localPosition = value;
        value = value.normalized;

        if (value.x >= 0.1f)
        {
            movePostion = new Vector2(1 * speed * Time.deltaTime, 0f);

            play.transform.rotation = Quaternion.Euler(0, -180, 0);

            if (jump.Onground == true)
            {
                anim.SetBool("Walking", true);
            }


        }

        else if (value.x <= -0.1f)
        {
            movePostion = new Vector2(-1 * speed * Time.deltaTime, 0f);


            play.transform.rotation = Quaternion.Euler(0, 360, 0);

            if (jump.Onground == true) {
                anim.SetBool("Walking", true);
            }
  
        }
        
   
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
      
        anim.SetBool("Walking", true);

    }

    public void OnPointerUp(PointerEventData eventData)
    {
     
        anim.SetBool("Walking", false);
        touch = false;
        Rect_joystick.localPosition = Vector2.zero;
        

    }

   


}
