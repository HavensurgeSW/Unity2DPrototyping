using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterFunctions : MonoBehaviour
{   
    TMP_Text texto;
    void Start(){
        texto = GetComponent<TMP_Text>();
    }
    void Update()
    {
        texto.text = "Paperclips: " + ClipManager.ReturnTotalClips();
    }
}
