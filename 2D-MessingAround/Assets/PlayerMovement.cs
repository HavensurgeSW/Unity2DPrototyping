using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 100;
    public Transform obj;

    [SerializeField]private Sprite moveUp;
    [SerializeField]private Sprite moveDown;
    [SerializeField]private Sprite moveLeft;
    [SerializeField]private Sprite moveRight;
    [SerializeField]private Sprite moveStill;

    public Color redColor;
    public Color defaultColor;

    private SpriteRenderer spr;

    void Start(){
        spr = GetComponent<SpriteRenderer>();
       
    }

    public void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        changeSprite(h,v);


        obj.transform.position += tempVect;
    }

    void changeSprite(float sprh, float sprv){


        if (sprh > 0)
            spr.sprite = moveRight;
        else
        {
            spr.sprite = moveLeft;
        }

        if(sprv > 0)
            spr.sprite = moveUp;
        else
        {
            spr.sprite = moveDown;
        }

        if(sprh==0&&sprv==0)
            spr.sprite = moveStill;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(Blink());
    }

    private IEnumerator Blink()
    {
        bool blinkstate = true;
        


        for (int i = 0; i < 10; i++)
        {
            if (blinkstate)
            {
                spr.color = defaultColor;
                blinkstate = !blinkstate;
            }
            else
            {
                spr.color = redColor;
                blinkstate = !blinkstate;
            }
            yield return new WaitForSeconds(0.3f);
        }

        spr.color = defaultColor;
    }
}
