using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class teki5 : MonoBehaviour

{
    public static GameObject player;
    float rotate ;
    [SerializeField]float x_speed ;
    float y_speed ;
    float TIME;
    [SerializeField] private GameObject tama;
    public Vector3 target;
    public GameObject text_manager;
    public float hp;
    public GameObject explosion_effect;
    float interval;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        text_manager = GameObject.FindGameObjectWithTag("text_manager");
        interval = 0;
    }

    // Update is called once per frame
    void Update()
    {
        y_speed += 15*Time.deltaTime;
        interval += Time.deltaTime; 

        Vector3 localAngle = this.transform.localEulerAngles;
        
        this.transform.Translate(x_speed,-15+y_speed,0,Space.World);

        if(interval >= 0.1f)
        {
            float rnd1 = Random.Range(-20f, 20f);
            float rnd2 = Random.Range(40f, 60f);
            float rnd3 = Random.Range(-60f, 40f);
            Instantiate(tama, transform.position, Quaternion.Euler(0,0,rnd1));
            Instantiate(tama, transform.position, Quaternion.Euler(0,0,rnd2));
            Instantiate(tama, transform.position, Quaternion.Euler(0,0,rnd3));
            interval = 0;    
        }

        if (transform.position.y > 700)
        {
			Destroy (gameObject);
        }

        this.transform.Rotate (0, 0, rotate);

        target = (this.transform.position - player.transform.position);
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
