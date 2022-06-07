using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AchievementHunter : MonoBehaviour
{
    List<int> achievements = new List<int>(5);
    public TMP_Text txt;


    private void Awake()
    {
        achievements[0] = 10;
        achievements[1] = 50;
        achievements[2] = 100;
        achievements[3] = 500;
        achievements[4] = 1000;
    }
    void Update()
    {
        foreach (var achievement in achievements)
        {
            if (ClipManager.ReturnTotalClips() == achievement)
                txt.text = "> Manufactured " + achievement + " paper clips!";
        }
    }



  
   
}
