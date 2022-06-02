using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIInteractions : MonoBehaviour
{
   public TMP_Text texto;
   public Color color1 = Color.red;
   public Camera cam;

   void Start(){
       cam.clearFlags = CameraClearFlags.SolidColor;
   }

   public void OnPointerEnter(){
       texto.text = "Dooon't. Don't you dare";
   }

   public void OnPointerLeave(){
       texto.text = "";
   }

   public void MfReallyClicked(){
       texto.text = "Wow, you really did it. Was it worth it?";
       cam.backgroundColor = color1;
       Invoke("ClearText", 3f);
   }

   void ClearText(){
       texto.text = "";       
   }

}
