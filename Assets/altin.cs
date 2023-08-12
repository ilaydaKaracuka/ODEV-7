using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altin : MonoBehaviour
{
    public int Altin=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="altin")
        {
            col.gameObject.SetActive(false);
            Altin += 50;


        }
    }

}
