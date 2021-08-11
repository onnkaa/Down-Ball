using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class kameraKontrol : MonoBehaviour
{

    public GameObject kameraknt;
    public GameObject arkaPlan1;
    public GameObject arkaPlan2;
    //public GameObject oyuncu;
    public Text puanText;
    //float score = 0f;
    //float highscore = 0;

    public float kameraHiz = 5;
    public float kameraHizArtıs;


    Rigidbody2D fizikbir;

    bool temasKontrol = true;
    bool yenidenBaslaKontrol = false;

    void Start()
    {
        //highscore = PlayerPrefs.GetFloat("kayit");
        fizikbir = kameraknt.GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.R) && yenidenBaslaKontrol)
        //{
        //    SceneManager.LoadScene("level1");
        //}

        if (temasKontrol)
        {
            kameraHizArtıs += Time.deltaTime;
            if (kameraHizArtıs > 10.0f)
            {
                kameraHiz += 0.25f;

                kameraHizArtıs = 0;
            }
        }




        if (temasKontrol)
        {
            //score += Time.deltaTime;
            

            fizikbir.velocity = new Vector2(0, -kameraHiz);
            if (kameraknt.transform.position.y <= arkaPlan2.transform.position.y)
            {
                arkaPlan1.transform.position = new Vector3(0, arkaPlan2.transform.position.y - 20);
            }
            if (kameraknt.transform.position.y <= arkaPlan2.transform.position.y - 20)
            {
                arkaPlan2.transform.position = new Vector3(0, arkaPlan1.transform.position.y - 20);
            }           
        }
        //score = Math.Round(score, 3);
        
        //puanText.text = "" + score*10;
       
        //Debug.Log(highscore);
        //if (score > highscore)
        //{
        //    highscore = score;
        //    PlayerPrefs.GetFloat("kayit", highscore);
        //}
    }

    //public void skorhesapla()
    //{
    //    //if (score > highscore)
    //    //{
    //    //    highscore = score;
    //    //    PlayerPrefs.GetFloat("kayit", highscore);
    //    //}

    //}

    public void oyunBitti()
    {
        
        temasKontrol = false;
        yenidenBaslaKontrol = true;
        fizikbir.velocity = Vector2.zero;
        
        //PlayerPrefs.SetFloat("score", score);
    }



    public void canGitti()
    {
        temasKontrol = false;
        fizikbir.velocity = Vector2.zero;
        //StartCoroutine(CagirilanMetot());
        temasKontrol = true;
        
    }

    //IEnumerator CagirilanMetot()
    //{
    //    temasKontrol = false;
    //    fizikbir.velocity = Vector2.zero;
    //    yield return new WaitForSeconds(1);  // 1 saniye bekliyor animasyon oynatmak için yazdım
    //    temasKontrol = true;
    //}
  
}
