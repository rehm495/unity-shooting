using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teki2 : MonoBehaviour
{
    public static GameObject player;
    Vector3 pos2;
    GameObject core;
    Vector3 core_position;
    float time;
    [SerializeField] private GameObject tama;
    float tama_interval;
    public Vector3 target;
    public GameObject text_manager;
    public float hp;
    public GameObject explosion_effect;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        text_manager = GameObject.FindGameObjectWithTag("text_manager");
        core = GameObject.FindGameObjectWithTag("Target");       
        var pos = this.transform.position;
       
        pos2 += (core_position - pos)*4*Time.deltaTime;
       
        pos2 -= pos*1*Time.deltaTime;
       
        pos += pos2*Time.deltaTime;
        transform.Rotate(0f, 0f, 20f);
       
        transform.position = pos;
        if(pos.y<= -700)
        {
           Destroy (this.gameObject);
        }
        time += Time.deltaTime;
        tama_interval += Time.deltaTime;
        if(time >= 2)
        {       
            core_position = core.transform.position;
            time = 0;   
        }
        target = (this.transform.position - player.transform.position);
        if(tama_interval >= 0.5)
        {       
            Instantiate(tama, transform.position, Quaternion.FromToRotation(Vector3.up, target));
            tama_interval = 0;   
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
}
