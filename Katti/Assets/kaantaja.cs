using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaantaja : MonoBehaviour
{

    Rigidbody rb;
   
    float suunta;
    GameObject paa;
    float alkuSijainti;
    public float hyppyRaja;
    public float hyppyVoima;
    Rigidbody rb2;
    float paanNopeus;
    float edellinenPaanSijainti;
    float paanSijainti;
    bool maassa;
    bool alkanut = false;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("Alku", 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        suunta = paa.transform.localRotation.eulerAngles.y;
        if (suunta> 40 && suunta <100 )
        {
            rb.AddTorque(new Vector3(0, 5, 0));
        }
        if (suunta < 320 && suunta > 260)
        {
            rb.AddTorque(new Vector3(0, -5, 0));
        }

        paanSijainti = paa.transform.position.y;
        paanNopeus = (paanSijainti - edellinenPaanSijainti) / Time.deltaTime;
        edellinenPaanSijainti = paanSijainti;
       

        if (paanNopeus > hyppyRaja && maassa && alkanut)
        {
            rb.AddForce(hyppyVoima * transform.up * paanNopeus);
            rb.AddForce(hyppyVoima * transform.forward);

        }

        /*if ()
        {

        }
        */

      
    }
    
    void Alku()

 
    {
        paa = GameObject.FindGameObjectWithTag("MainCamera");
        alkanut = true;
        // alkuSijainti = paa.transform.position.y;
    }

    private void OnCollisionEnter(Collision collision)
    {
        maassa = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        maassa = false;
    }

}
