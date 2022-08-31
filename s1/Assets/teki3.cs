using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teki3 : MonoBehaviour
{
    float time;
    public static GameObject player;
    public int way;
    public int way_space;
    float tama_shot;
    float angle;
    public GameObject tama;
    public GameObject text_manager;
    public float hp;
    public GameObject explosion_effect;
    // Start is called before the first frame update
    void Start()
    {
       text_manager = GameObject.FindGameObjectWithTag("text_manager");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time <= 1)
        {
            this.transform.Translate (0,-15 + Mathf.Round(time*10)*1.5f,0);
        }
        else
        {
            tama_shot += Time.deltaTime;
        }
        if(tama_shot >= 1)
        {
            shot();
            tama_shot = 0;
        }
        if(hp <= 0)
        {
            Instantiate(explosion_effect, transform.position, Quaternion.identity);
            Destroy (gameObject);
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
            Instantiate(tama, transform.position, Quaternion.Euler(0,0,angle));
        }        
    }
}

