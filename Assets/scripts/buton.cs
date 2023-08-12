using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buton : MonoBehaviour
{
    public void Cikis()
    {
        Application.Quit();
    }
    public void YeniOyun()
    {
        SceneManager.LoadScene(0);
    }
}
