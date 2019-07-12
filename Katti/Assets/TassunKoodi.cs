using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TassunKoodi : MonoBehaviour

{

    public string ohjainNimi;
    public GameObject katti;
    Rigidbody rb;
    Vector3 suunta;
    public float nopeus;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = katti.GetComponent<Rigidbody>();
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = GameObject.FindGameObjectWithTag(ohjainNimi).transform.position - new Vector3(0, 0.05f, 0);
        transform.rotation = GameObject.FindGameObjectWithTag(ohjainNimi).transform.rotation;
        suunta = katti.transform.position - transform.position;
       // rb.AddTorque(GameObject.FindGameObjectWithTag("MainCamera").transform.rotation.eulerAngles);
    }


    private void OnTriggerEnter(Collider other)
    {
        
        rb.AddForce(suunta * -nopeus);
    }
}
