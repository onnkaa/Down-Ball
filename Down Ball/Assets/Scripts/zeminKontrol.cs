using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminKontrol : MonoBehaviour {

    kameraKontrol KameraKontrol;

    public GameObject[] zemin;

    
    float canCikmaZamani;

    public int kacAdetZemin;
    public int kacAdetDikenliZemin;
    public int toplamZemin;

    GameObject[] zeminler;

    Rigidbody2D fizikzemin;

    float koordinat = -5.75f;

    void Update()
    {      
        zeminler = new GameObject[kacAdetZemin];
        canCikmaZamani += Time.deltaTime;

        int counter = 0;

        if (toplamZemin<18)
        {
            for (int i = 0; i < zeminler.Length; i++)
            {
                int randomIndex = Random.Range(0, 3);

                if (randomIndex == 1 && counter < kacAdetDikenliZemin)
                {
                    zeminler[i] = Instantiate(zemin[1], new Vector2(64, 17), Quaternion.identity);
                    counter++;
                    
                }
                else if(randomIndex == 2 && canCikmaZamani>=10)
                {
                    zeminler[i] = Instantiate(zemin[2], new Vector2(64, 17), Quaternion.identity);
                    canCikmaZamani = 0;
                }
                else
                {
                    zeminler[i] = Instantiate(zemin[0], new Vector2(64, 17), Quaternion.identity);
                    
                }

                Rigidbody2D fizikzemin = zeminler[i].AddComponent<Rigidbody2D>();
                fizikzemin.gravityScale = 0;
                fizikzemin.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
                fizikzemin.freezeRotation = true;
                toplamZemin++;
            }
            

            for (int i = 0; i < zeminler.Length; i++)
            {
                float xEksenim = Random.Range(-2.5f, 3.50f);

                zeminler[i].transform.position = new Vector3(xEksenim, koordinat);
                koordinat = koordinat - 2.75f;
            }
        }      
    }

    public void toplamZeminArttir(int gelenZemin)
    {        
        toplamZemin += gelenZemin;       
    }

}
