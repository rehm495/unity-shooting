using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_move : MonoBehaviour
{
    public int boss_term;
    float interval,time;
    int move;
    float rnd_x;
    float rnd_y;
    Vector3 oldpos;
    // Start is called before the first frame update
    void Start()
    {
        interval = 0;
        boss_term = 1;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-450,450);
        pos.y = Mathf.Clamp(pos.y,100,400);
        transform.position = pos;
        interval += Time.deltaTime;
        boss_term = this.gameObject.GetComponent<boss>().boss_term;
        if(boss_term == 1)
        {
            if(this.transform.position.x > 0)
            {
                this.transform.Translate (-50,0,0);
            }
            else
            {
                if(Input.GetKey (KeyCode.Z))
                {
                    Invoke("commencement",1);
                }
            }
        }
        if(boss_term == 2)
        {
            if(interval >= 2)
            {
                move = 1;
                rnd_x = Random.Range(-5f, 5f);
                rnd_y = Random.Range(-5f, 5f);
                interval = 0;
            }
            if(move == 1)
            {
                this.transform.Translate(rnd_x,rnd_y,0);
                if(interval >= 0.7)
                {
                    move = 0;
                }
            }
            oldpos = this.transform.position;
        }

        if(boss_term == 3)
        {
            time += Time.deltaTime;
            var a = Vector3.Lerp(oldpos, new Vector3(0,400,0), time*3);
            this.transform.position = a;
            if(this.transform.position == new Vector3(0,400,0))
            {
                boss_term = 4;
                time = 0;
            }
        }
    }
    void commencement()
    {
        boss_term = 2;
    }
}
