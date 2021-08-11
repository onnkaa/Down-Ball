using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girisKameraKontrol : MonoBehaviour {

	public GameObject kameraknt;
    public GameObject arkaPlan1;
    public GameObject arkaPlan2;
    public float kameraHiz = 5;
    Rigidbody2D fizikbir;

    void Start ()
    {
        fizikbir = kameraknt.GetComponent<Rigidbody2D>();
        fizikbir.velocity = new Vector2(0, -kameraHiz);
    }
	
	
	void Update ()
    {
        

        if (kameraknt.transform.position.y <= arkaPlan2.transform.position.y)
        {
            arkaPlan1.transform.position = new Vector3(0, arkaPlan2.transform.position.y - 20);
        }
        if (kameraknt.transform.position.y <= arkaPlan2.transform.position.y - 20)
        {
            arkaPlan2.transform.position = new Vector3(0, arkaPlan1.transform.position.y - 20);
        }
    }
}
