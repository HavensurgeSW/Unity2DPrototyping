using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator playerAnimator;
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LookAroundAnim(){
        playerAnimator.SetTrigger("LookAround");
    }
}
