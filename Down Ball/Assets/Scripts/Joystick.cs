using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    //private PlayerKontrol playerHareket;
    private topKontrol TopHareket;

    void Start()
    {
        TopHareket = GameObject.Find("Player1").GetComponent<topKontrol>();
    }
    public void OnPointerDown(PointerEventData veri)
    {
        if (gameObject.name == "SolBtn")
        {
            TopHareket.AyarlaSolaGit(true);
        }
        else
        {
            TopHareket.AyarlaSolaGit(false);
        }
    }
    public void OnPointerUp(PointerEventData veri)
    {
        TopHareket.HareketiDurdur();
    }

   
}
