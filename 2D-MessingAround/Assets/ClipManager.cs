using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipManager : MonoBehaviour
{
    static int totalClips;
    public static ClipManager Instance{get; private set;}
    private void Awake() { 
    if (Instance != null && Instance != this){ 
        Destroy(this); 
    }else{ 
        Instance = this; 
        } 
    }

    void Start()
    {
        totalClips = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddClip(){
        totalClips++;
    }
    public static int ReturnTotalClips(){
        Debug.Log("test");
        return totalClips;
    }
}
