using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class HideViveControllers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Piilota", 1);
        Invoke("Piilota", 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Piilota()
    {
        //GameObject[] ohjaimet = Resources.FindObjectsOfTypeAll<GameObject>().Where(obj => obj.name == "body");


        
            Destroy(GameObject.Find("controller(Clone)"));
        

    }
}
