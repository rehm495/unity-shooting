using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziki_right : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey (KeyCode.RightArrow)&&(!(Input.GetKey (KeyCode.LeftArrow) && (Input.GetKey (KeyCode.RightArrow)))))
        {
            this.GetComponent<SpriteRenderer>().color = new Color(255,255,255,255);
        }
        else
        {
            this.GetComponent<SpriteRenderer>().color = new Color(255,255,255,0);
        }
    }
}
