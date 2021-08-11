using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanAyar : MonoBehaviour {

	
	void Start ()
    {
        SpriteRenderer mySprite = GetComponent<SpriteRenderer>();
        Vector3 skala = transform.localScale;

        float width = mySprite.sprite.bounds.size.x;

        float dunyaYukseklik = Camera.main.orthographicSize * 2f;

        float dunyaGenislik = dunyaYukseklik / Screen.height * Screen.width;

        skala.x = dunyaGenislik / width;
        transform.localScale = skala;
	}
	
	
	void Update ()
    {
		
	}
}
