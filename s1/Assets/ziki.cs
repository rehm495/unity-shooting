using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziki : MonoBehaviour
{
    [SerializeField] GameObject tama;  //弾
    [SerializeField] float tama_interval;  //弾発射間隔
    float tama_shot;
    int shot_situation;
    int ziki_hp;
    MeshRenderer mr;
        // Start is called before the first frame update
    void Start()
    {
        ziki_hp = 20;
    }

    // Update is called once per frame
    void Update()
    {
        ziki_hp = Mathf.Clamp(ziki_hp,0,100000);
        if(Input.GetKey (KeyCode.LeftArrow))
        {
            if(!(Input.GetKey (KeyCode.LeftArrow) && (Input.GetKey (KeyCode.RightArrow))))
            {
                this.GetComponent<SpriteRenderer>().color = new Color(255,255,255,0);
            }
            if(Input.GetKey (KeyCode.LeftShift))
            {
                this.transform.Translate (-4,0,0);
            }

            else
            {
                this.transform.Translate(-8,0,0);
            }
        }

        if(Input.GetKey (KeyCode.RightArrow))
        {
            if(!(Input.GetKey (KeyCode.LeftArrow) && (Input.GetKey (KeyCode.RightArrow))))
            {
                this.GetComponent<SpriteRenderer>().color = new Color(255,255,255,0);
            }
            if(Input.GetKey (KeyCode.LeftShift))
            {
                this.transform.Translate (4,0,0);
            }

            else
            {
                this.transform.Translate(8,0,0);
            }
        }
        if((!(Input.GetKey (KeyCode.LeftArrow) || (Input.GetKey (KeyCode.RightArrow))))||(Input.GetKey (KeyCode.LeftArrow) && (Input.GetKey (KeyCode.RightArrow))))
        {
            this.GetComponent<SpriteRenderer>().color = new Color(255,255,255,255);   
        }

        if(Input.GetKey (KeyCode.UpArrow))
        {
            if(Input.GetKey (KeyCode.LeftShift))
            {
                this.transform.Translate (0,4,0);
            }
            
            else
            {
                this.transform.Translate(0,8,0);
            }
        }
        if(Input.GetKey (KeyCode.DownArrow))
        {
            if(Input.GetKey (KeyCode.LeftShift))
            {
                this.transform.Translate (0,-4,0);
            }

            else
            {
                this.transform.Translate(0,-8,0);
            }
        }
        Vector3 Coordinate = transform.position;
        Coordinate.x = Mathf.Clamp(Coordinate.x,-450,450);
        Coordinate.y = Mathf.Clamp(Coordinate.y,-500,500);
        transform.position = Coordinate;
        
        tama_shot += Time.deltaTime;
        if(tama_shot > tama_interval)
            {
                tama_shot = 0.0f;
            }
        
        if (Input.GetKey (KeyCode.Z))
        {
            if(tama_shot <= 0.0f )
            {
                Instantiate(tama, transform.position, Quaternion.identity);//オブジェクト「弾」をコピー
                Instantiate(tama, transform.position, Quaternion.Euler(0,0,5));
                Instantiate(tama, transform.position, Quaternion.Euler(0,0,-5));
            }
        }
    }
}
