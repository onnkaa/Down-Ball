//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerKontrol : MonoBehaviour {

//    public float karakterHizi = 8f, maxSurat = 4f;
//    private Rigidbody2D myRigidbody;

//    private bool solaGit, sagaGit;
//    void Awake()
//    {
//        myRigidbody = GetComponent<Rigidbody2D>();
//    }
//	void Start ()
//    {
		
//	}
	
	
//	void FixedUpdate ()
//    {
//        if (solaGit)
//        {
//            SolaGit();
//        }
//        if (sagaGit)
//        {
//            SagaGit();
//        }
//	}
//    public void AyarlaSolaGit(bool solaGit)
//    {
//        this.solaGit = solaGit;
//        this.sagaGit = !solaGit;
//    }
//    public void HareketiDurdur()
//    {
//        solaGit = sagaGit = false;
//    }
//    void SolaGit()
//    {
//        float Xdurdur = 0f;
//        float surat = Mathf.Abs(myRigidbody.velocity.x);


//        if (surat < maxSurat)

//            Xdurdur = -karakterHizi;

//        Vector3 yon = transform.localScale;
//        yon.x = -0.3f;
//        transform.localScale = yon;

//        myRigidbody.AddForce(new Vector2(Xdurdur, 0));
//    }
//    void SagaGit()
//    {
//        float Xdurdur = 0f;
//        float surat = Mathf.Abs(myRigidbody.velocity.x);


//        if (surat < maxSurat)

//            Xdurdur = karakterHizi;

//        Vector3 yon = transform.localScale;
//        yon.x = 0.3f;
//        transform.localScale = yon;

//        myRigidbody.AddForce(new Vector2(Xdurdur, 0));
//    }

    
//}
