using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    int skor;
    // Start is called before the first frame update
    private int p = 0;
    public TextMeshProUGUI textyaz;
    public TextMeshProUGUI textyaz2;
    public TextMeshProUGUI text3;
    private int can;
    void Start()
    {   
        textyaz.text = 0.ToString(); //ilk ba� da 0 say�s�n� stringe �evirip yazs�n
        PlayerPrefs.SetInt("EnYuksekSkor", 1300); //26 alt�n var her biri 50 de�erinde 

         
    }

    // Update is called once per frame
    void Update()
    {
        p = GetComponent<ToplamAltin>().para;
        can = GetComponent<ToplamAltin>().cansayisi;

        textyaz.text = p.ToString(); //toplanan alt�n say�s�n� yazar text'de
         textyaz2.text= " CAN =" + can;
        text3.text = "SKOR = " + (50 * p);  //her bir alt�n 50 de�erinde
}
}
