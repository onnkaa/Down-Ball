using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class topKontrol : MonoBehaviour
{
    int reklamSayaci = 0;
    float reklamScore;
    public GameObject yenidenPanel;
    public GameObject durdurButton;

    private Rigidbody2D myRigidbody;
    kameraKontrol KmrKontrol;

    public GameObject patlama;
    GameObject kameraKont;

    public float can = 1;
    float Score = 0;
    float HighScore = 0;

    bool scoreArtis=true;

    public Text canTxt;
    public Text scoreText;

    float maxSurat = 7f;
    public float speed;
    Vector3 vec;

    public GameObject kamera;
    public GameObject oyuncu;
    Vector3 kameraIlkPos;
    Vector3 kameraSonPos;
    Vector3 oyuncuPos;
    Vector3 kameraPos;

    private bool solaGit, sagaGit;

    [SerializeField]
    private AudioClip olumSes, canSes;

    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        KmrKontrol = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<kameraKontrol>();
        kameraKont = GameObject.FindGameObjectWithTag("MainCamera");
        kameraIlkPos = new Vector3(0, kamera.transform.position.y, -10);
        kameraPos = new Vector3(0, kamera.transform.position.y);
        HighScore = PlayerPrefs.GetFloat("kayit");

        //reklam işlemi
        reklamSayaci = PlayerPrefs.GetInt("reklamSayaci");
        reklamSayaci++;
        PlayerPrefs.SetInt("reklamSayaci", reklamSayaci);
    }


    void FixedUpdate()
    {
        if (solaGit)
        {
            SolaGit();
        }
        if (sagaGit)
        {
            SagaGit();
        }

        //karakterHareket();
    }
    public void AyarlaSolaGit(bool solaGit)
    {
        this.solaGit = solaGit;
        this.sagaGit = !solaGit;
    }
    public void HareketiDurdur()
    {
        solaGit = sagaGit = false;
    }
    void SolaGit()
    {
        //transform.Translate(Vector2.left * speed * Time.deltaTime);
        float Xdurdur = 0f;
        float surat = Mathf.Abs(myRigidbody.velocity.x);
        if (surat < maxSurat)
            Xdurdur = -speed;


        myRigidbody.AddForce(new Vector2(Xdurdur, 0));
    }
    void SagaGit()
    {
        //transform.Translate(Vector2.right * speed * Time.deltaTime);
        float Xdurdur = 0f;
        float surat = Mathf.Abs(myRigidbody.velocity.x);
        if (surat < maxSurat)
            Xdurdur = speed;


        myRigidbody.AddForce(new Vector2(Xdurdur, 0));

        //void karakterHareket()
        //{
        //    float h = Input.GetAxisRaw("Horizontal");
        //    GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
        //}
    }

    private void Update()
    {
        reklamScore += Time.deltaTime;
        canTxt.text = "X" + can;
        oyuncuPos = new Vector3(0, transform.position.y, 0);
        kameraPos = new Vector3(0, kamera.transform.position.y, -10);
        takip();
        

        if (scoreArtis)
        {
            Score += Time.deltaTime;
            scoreText.text = "" + Score * 10;
        }
    }
    void takip()
    {
        if (oyuncu.transform.position.y < kamera.transform.position.y)
        {
            kamera.transform.position = Vector3.Lerp(kameraPos, oyuncuPos, 0.04f); // lerp kamera yumuşatma kodu
        }
    }
    public void TekrarPanel()
    {
        yenidenPanel.SetActive(true);
        scoreArtis = false;
        //if (reklamScore >= 30)
        //{
        //    GameObject.FindGameObjectWithTag("reklam").GetComponent<reklam>().reklamiGoster();            
        //}
        //if (reklamSayaci == 3)
        //{
        //    GameObject.FindGameObjectWithTag("reklam").GetComponent<reklam>().reklamiGoster();
        //    PlayerPrefs.SetInt("reklamSayaci", 0);
        //}
        
    }

    public void olumReklam()
    {
        if (reklamScore >= 30)
        {
            GameObject.FindGameObjectWithTag("reklam").GetComponent<reklam>().reklamiGoster();
        }
        if (reklamSayaci == 3)
        {
            GameObject.FindGameObjectWithTag("reklam").GetComponent<reklam>().reklamiGoster();
            PlayerPrefs.SetInt("reklamSayaci", 0);
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (can == 0)
        {

            if (col.gameObject.tag == "diken")
            {
                durdurButton.SetActive(false);
                scoreArtis = false;
                Destroy(gameObject);
                Instantiate(patlama, transform.position, transform.rotation);
                AudioSource.PlayClipAtPoint(olumSes, transform.position);
                KmrKontrol.oyunBitti();
                TekrarPanel();
                olumReklam();
                //KmrKontrol.skorhesapla();
                if (Score > HighScore)
                {
                    HighScore = Score;
                    PlayerPrefs.SetFloat("kayit", HighScore);
                }
            }
            if (col.gameObject.tag == "ustengel")
            {
                durdurButton.SetActive(false);
                scoreArtis = false;
                Destroy(gameObject);
                Instantiate(patlama, transform.position, transform.rotation);
                AudioSource.PlayClipAtPoint(olumSes, transform.position);
                KmrKontrol.oyunBitti();
                TekrarPanel();
                olumReklam();
                //KmrKontrol.skorhesapla();
                if (Score > HighScore)
                {
                    HighScore = Score;
                    PlayerPrefs.SetFloat("kayit", HighScore);
                }
            }

            if (col.gameObject.tag == "altengel")
            {
                durdurButton.SetActive(false);
                scoreArtis = false;
                Destroy(gameObject);
                Instantiate(patlama, transform.position, transform.rotation);
                AudioSource.PlayClipAtPoint(olumSes, transform.position);
                KmrKontrol.oyunBitti();
                TekrarPanel();
                olumReklam();
                //KmrKontrol.skorhesapla();
                if (Score > HighScore)
                {
                    HighScore = Score;
                    PlayerPrefs.SetFloat("kayit", HighScore);
                }
            }
            if (col.gameObject.tag == "can")
            {
                Destroy(col.gameObject);
                AudioSource.PlayClipAtPoint(canSes, transform.position);
                can++;
            }


        }
        else if (can > 0)
        {
            if (col.gameObject.tag == "diken")
            {
                AudioSource.PlayClipAtPoint(olumSes, transform.position);
                can--;
                KmrKontrol.canGitti();
                kameraSonPos = kameraIlkPos + oyuncuPos;
                kamera.transform.position = Vector3.Lerp(kamera.transform.position, kameraSonPos, 0.1f); // lerp kamera yumuşatma kodu

            }
            if (col.gameObject.tag == "ustengel")
            {
                AudioSource.PlayClipAtPoint(olumSes, transform.position);
                can--;
                KmrKontrol.canGitti();
                kameraSonPos = kameraIlkPos + oyuncuPos;
                kamera.transform.position = Vector3.Lerp(kamera.transform.position, kameraSonPos, 0.1f); // lerp kamera yumuşatma kodu

            }

            if (col.gameObject.tag == "altengel")
            {
                AudioSource.PlayClipAtPoint(olumSes, transform.position);
                can--;
                KmrKontrol.canGitti();
                kameraSonPos = kameraIlkPos + oyuncuPos;
                kamera.transform.position = Vector3.Lerp(kamera.transform.position, kameraSonPos, 0.1f); // lerp kamera yumuşatma kodu

            }
            if (col.gameObject.tag == "can")
            {
                AudioSource.PlayClipAtPoint(canSes, transform.position);
                Destroy(col.gameObject);
                can++;
            }
        }

    }

    IEnumerator CagirilanMetot()
    {


        yield return new WaitForSeconds(2);  // 1 saniye bekliyor animasyon oynatmak için yazdım
        KmrKontrol.canGitti();
    }

}
