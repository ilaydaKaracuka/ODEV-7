using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToplamAltin : MonoBehaviour
{
    public int cansayisi ;
    public int para;
    public TextMeshProUGUI text2;
    public Canvas canvas;
    void Start()
    {
        canvas.enabled=false;
        cansayisi = 5;
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="altin")
        {
            col.gameObject.SetActive(false);
            para += 1;


        }

        if (col.gameObject.tag == "bariyer") //bariyere çarparsa 
        {


            if (cansayisi < 2|| para<1) //bariyere çarptýysa can sayisi 2 den küçükse ve altýný<1 ise
                SceneManager.LoadScene(1);
            if (para < 1) //eðer 1 altýn yoksa 2 can kaybetsin varsa 1 altýn kaybetsin
                cansayisi =cansayisi- 2;
            else
                para -= 1; //altýn eksilsin
         
            if (cansayisi == 0)
                SceneManager.LoadScene(1); //gameover yazsýn


        }

    }
   
    private void OnTriggerExit(Collider other) //kapýdan cýkýnca oyun bitsin tebrikler yazsýn
    {
        if(other.gameObject.name=="door_frame")
        {
            other.gameObject.SetActive(false);

            canvas.enabled = true;
            text2.text = "Tebrikler  "+"  "+ "SKOR = " + (para*50) ;

        }
    }

}


