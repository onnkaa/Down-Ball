using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin : MonoBehaviour
{

    GameObject ZeminKontrol;
    zeminKontrol kontrol;
 
    void Start()
    {
        
        ZeminKontrol = GameObject.FindGameObjectWithTag("zeminkontrol");
        kontrol = ZeminKontrol.GetComponent<zeminKontrol>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "zemindiken")
        {
            Destroy(col.gameObject);

            kontrol.toplamZeminArttir(-1);
        }

        if (col.gameObject.tag == "normzemin")
        {
            Destroy(col.gameObject);
            
            kontrol.toplamZeminArttir(-1);
        }
       

    }
}
