using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class sound_block : MonoBehaviour , IPointerDownHandler 
{
    private int Count= 2;
    public Animator anim;
    private void Start()
    {
        AudioListener.volume = 3;
        AudioListener.pause = false;
        anim.SetBool("Sound", true);
    }
    public void OnPointerDown()
    {
       
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (Count % 2 == 0)
        {
            anim.SetBool("Sound", false);
            AudioListener.volume = 0;
            AudioListener.pause = true;
        }
        else if (Count % 2 != 0)
        {
            anim.SetBool("Sound", true);
            AudioListener.volume = 3;
            AudioListener.pause = false;

        }
        Count++;
    }
}
