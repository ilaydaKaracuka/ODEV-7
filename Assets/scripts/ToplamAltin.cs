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

        if (col.gameObject.tag == "bariyer") //bariyere �arparsa 
        {


            if (cansayisi < 2|| para<1) //bariyere �arpt�ysa can sayisi 2 den k���kse ve alt�n�<1 ise
                SceneManager.LoadScene(1);
            if (para < 1) //e�er 1 alt�n yoksa 2 can kaybetsin varsa 1 alt�n kaybetsin
                cansayisi =cansayisi- 2;
            else
                para -= 1; //alt�n eksilsin
         
            if (cansayisi == 0)
                SceneManager.LoadScene(1); //gameover yazs�n


        }

    }
   
    private void OnTriggerExit(Collider other) //kap�dan c�k�nca oyun bitsin tebrikler yazs�n
    {
        if(other.gameObject.name=="door_frame")
        {
            other.gameObject.SetActive(false);

            canvas.enabled = true;
            text2.text = "Tebrikler  "+"  "+ "SKOR = " + (para*50) ;

        }
    }

}


