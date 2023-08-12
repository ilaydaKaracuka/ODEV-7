using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour

{
    private float XRotation = 0.0f;
    public float sensivity = 50f;
    public GameObject oyuncu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensivity;
        XRotation -= mouseY;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
        oyuncu.transform.Rotate(Vector3.up * mouseX);
    }
}
