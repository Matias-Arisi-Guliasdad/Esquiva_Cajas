using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosManager : MonoBehaviour
{
    public TextMeshProUGUI TextoTiempo;
    float Tiempo = 0f;
    public bool Pausa = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Pausa==true){
             Tiempo+= Time.deltaTime;
        TextoTiempo.text = "Tiempo: " + Tiempo.ToString("F2") + "s";
        }
    }
}
