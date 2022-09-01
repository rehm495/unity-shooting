using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    float time;
    public static GameObject player;
    public int way;
    public int way_space;
    float tama_shot,tama2_shot;
    float angle;
    public Vector3 target;
    public GameObject tama,tama2,tama3;
    public GameObject knife;
    public GameObject text_manager;
    public float hp,max_hp;
    public GameObject explosion_effect;
    public int boss_term;
    public Vector3 a,b,c;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        text_manager = GameObject.FindGameObjectWithTag("text_manager");
        boss_term = 1;
    }

    // Update is called once per frame
    void Update()
    {
        tama_shot += Time.deltaTime;
        tama2_shot += Time.deltaTime;
        boss_term = this.gameObject.GetComponent<boss_move>().boss_term;
        if(boss_term == 1)
        {
            max_hp = 100;
        }
        if(boss_term == 2)
        {
            if(tama_shot >= 0.5f)
            {
                shot();
                tama_shot = 0;
            }
            if(hp <= 0)
            {
                boss_term ++;
            }
            target = (this.transform.position - player.transform.position);
        }
        if(boss_term == 3)
        {
            max_hp = 400;
            hp = 400;
        }
        if(boss_term == 4)
        {
            target = (this.transform.position - player.transform.position);
            way = 32;
            if(tama2_shot >= 2)
            {
                shot2();
                tama2_shot = 0;
            }
            if(tama_shot >= 0.5f)
            {
                shot();
                tama_shot = 0;
            }
            if(hp <= 200)
            {
                boss_term ++;
            }
            
        }
        if(boss_term == 5)
        {
            way = 15;
            way_space = 20;
            tama = tama2;
            target = (this.transform.position - player.transform.position);
            if(tama_shot >= 2f)
            {
                shot();
                tama_shot = 0;
            }
            if(tama2_shot >= 0.2f)
            {
                shot3();
                tama2_shot = 0;
            }
            if(hp <= 0)
            {
                boss_term ++;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D coll) 
    {
        if (coll.gameObject.tag == "Player")
        {
            text_manager.GetComponent<text_manager>().Damage();
            hp--;
        }
        if (coll.gameObject.tag == "ziki_tama")
        {
            Destroy (coll.gameObject);
		    hp--;
        }
        
	}
    private void shot()
    {
        for(int i = 0; i < way; ++i )
        {
            angle = way_space*(i - Mathf.CeilToInt(way/2));
            Instantiate(tama, transform.position, Quaternion.FromToRotation(Vector3.up, target)*Quaternion.Euler(0,0,angle));
        }
    }
    private void shot2()
    {
        Vector3 pos = this.transform.position;
        Vector3 player_pos = player.transform.position;
        for(int i = 0; i < 11; ++i )
        {
            if(i%2 == 0)
            {
                Instantiate(knife, transform.position, Quaternion.identity);
                knife.GetComponent<knife>().p1 = pos;
                knife.GetComponent<knife>().p2 = new Vector3(1000,500,0);
                knife.GetComponent<knife>().p3 = player_pos + new Vector3(0,100*(i - Mathf.CeilToInt((7/2))),0);
            }
            else
            {
                Instantiate(knife, transform.position, Quaternion.identity);
                knife.GetComponent<knife>().p1 = pos;
                knife.GetComponent<knife>().p2 = new Vector3(-1000,500,0);
                knife.GetComponent<knife>().p3 = player_pos + new Vector3(0,100*(i - Mathf.CeilToInt((7/2))),0);
            }
        }
    }
    private void shot3()
    {
        for(int i = 0; i < 36; ++i )
        {
            float rnd1 = Random.Range(-20f, 20f);
            angle = 10*(i - Mathf.CeilToInt(36/2));
            Instantiate(tama3, transform.position, Quaternion.FromToRotation(Vector3.up, target)*Quaternion.Euler(0,0,angle + rnd1));
        }   
    }
    
}
