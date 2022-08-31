using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour
{
    public Vector3 p1;public Vector3 p2;public Vector3 p3;
    float time;
    bool move2;
    Vector3 target;
    Vector3 b;
    GameObject text_manager;
    // Start is called before the first frame update
    void Start()
    {
        p1 = this.transform.position;
        move2 = false;
        text_manager = GameObject.FindGameObjectWithTag("text_manager");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y<= -700||this.transform.position.y>= 700||this.transform.position.x<= -700||this.transform.position.x>= 700)
        {
           Destroy (this.gameObject);
        }           
        transform.rotation = Quaternion.FromToRotation(Vector3.up, target);
        if(move2 == false)
        {
            time += Time.deltaTime/2;
            var a = Vector3.Lerp(p1, p2, time);
            b = Vector3.Lerp(p2, p3, time);
            var c = Vector3.Lerp(a, b, time);
            this.transform.position = c;
            if(!(b - this.transform.position == new Vector3(0,0,0)))
            {
                target = b - this.transform.position; 
            }
        }
        if(this.transform.position == p3)
        {
            move2 = true;//ベジェ曲線から直線移動に移行
        }
        if(move2 == true)//直線移動
        {
            this.transform.Translate (0,20,0);
        }
        
    }
    void OnTriggerEnter2D(Collider2D coll) 
    {
        if (coll.gameObject.tag == "Player")
        {
            text_manager.GetComponent<text_manager>().Damage();
            Destroy (this.gameObject);
        }
	}
}
